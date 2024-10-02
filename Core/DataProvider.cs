using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.Common;

namespace CafeShop.Core;

public class DataProvider
{
    private static readonly string _connectionString = GetConnectionString();

    private static string GetConnectionString() => new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                                                        .AddJsonFile("appsettings.json").Build()
                                                        .GetConnectionString("SQLServer");
    private static DataProvider _instance;
    public static DataProvider Instance
    {
        get
        {
            _instance ??= new DataProvider();
            return _instance;
        }
        private set => _instance = value;
    }

    private DataProvider()
    {
    }

    private static readonly IList<DbParameter> Parameters = [];
    public DataTable ExecuteSPDataTable(string procedureName)
    {
        DataTable dtTable = new();
        using SqlConnection connection = new(_connectionString);
        try
        {
            connection.Open();

            using SqlCommand cmd = new(procedureName, connection);
            cmd.CommandType = CommandType.StoredProcedure;

            foreach (DbParameter parameter in Parameters)
            {
                cmd.Parameters.Add(parameter);
            }

            using SqlDataAdapter dataAdapter = new(cmd);
            dataAdapter.Fill(dtTable);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "DataProvider Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dtTable = null;
        }
        finally
        {
            connection.Close();
            foreach (var param in Parameters.Where(x => x.Direction == ParameterDirection.Input).ToList())
            {
                Parameters.Remove(param);
            }
        }
        return dtTable;
    }

    public void AddInputParameter(string name, object value)
    {
        DbParameter dbParameter = new SqlParameter()
        {
            ParameterName = name,
            Direction = ParameterDirection.Input,
            Value = value ?? DBNull.Value
        };
        Parameters.Add(dbParameter);
    }

}
