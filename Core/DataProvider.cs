using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic.Logging;
using System.Data;
using System.Data.Common;
using System.Globalization;
using System.Reflection;

namespace CafeShop.Core;

public class DataProvider
{
    private static readonly string _connectionString = GetConnectionString();
    private readonly int _timeout = 30;
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

    private T Execute<T>(Func<DbCommand, T> func, CommandType commandType, string commandText)
    {
        T result = default;
        using SqlConnection connection = new(_connectionString);
        try
        {
            connection.Open();
            using SqlCommand command = connection.CreateCommand();
            command.CommandTimeout = _timeout;
            command.CommandType = commandType;
            command.CommandText = commandText;
            foreach (DbParameter parameter in Parameters)
            {
                command.Parameters.Add(parameter);
            }
            result = func(command);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "DataProvider Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            connection.Close();
            foreach (var param in Parameters.Where(x => x.Direction == ParameterDirection.Input).ToList())
            {
                Parameters.Remove(param);
            }
        }
        return result;
    }

    protected DataTable ExecuteSPDataTable(string spName)
    {
        return Execute(command =>
        {
            DataTable dataTable = new DataTable();
            using (DbDataAdapter dataAdapter = new SqlDataAdapter())
            {
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataTable);
            }
            return dataTable;
        }, CommandType.StoredProcedure, spName);
    }

    protected DataTable ExecuteSQLDataTable(string sqlText)
    {
        return Execute(command =>
        {
            DataTable dataTable = new DataTable();
            using (DbDataAdapter dataAdapter = new SqlDataAdapter())
            {
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataTable);
            }
            return dataTable;
        }, CommandType.Text, sqlText);
    }

    public List<T> Extract<T>(DataTable dt) where T : class
    {
        List<T> ts = [];
        foreach (DataRow dr in dt.Rows)
        {
            ts.Add(Extract<T>(dr));
        }
        return ts;
    }

    public T Extract<T>(DataRow dr) where T : class
    {
        Type type = typeof(T);
        T instance = type.IsPrimitive || type == typeof(string) ? default : (T)Activator.CreateInstance(type);
        if (instance is IDictionary<string, string> dictionary)
        {
            for (int i = 0; i < dr.Table.Columns.Count; ++i)
            {
                dictionary.Add(dr.Table.Columns[i].ColumnName, dr[i]?.ToString());
            }
            return instance;
        }
        for (int i = 0; i < dr.Table.Columns.Count; ++i)
        {
            if (!(dr[i] is DBNull))
            {
                object obj = dr[i];
                PropertyInfo property = type.GetProperty(dr.Table.Columns[i].ColumnName);
                if (property != null)
                {
                    try
                    {
                        Type targetType = property.PropertyType;
                        if (obj.GetType() != targetType)
                        {
                            if (targetType.IsEnum)
                            {
                                obj = System.Enum.Parse(targetType, obj.ToString());
                            }
                            else
                            {
                                obj = Convert.ChangeType(obj, targetType, CultureInfo.InvariantCulture);
                            }
                        }
                        property.SetValue(instance, obj);
                    }
                    catch { }
                }
                else if (obj.GetType() == type)
                {
                    instance = (T)obj;
                }
            }
        }
        return instance;
    }

    public List<T> ExecuteProcedureGetList<T>(string procedureName) where T : class => Extract<T>(ExecuteSPDataTable(procedureName));

    public List<T> ExecuteSQLGetList<T>(string sqlText) where T : class => Extract<T>(ExecuteSQLDataTable(sqlText));

    public T ExecuteProcedure<T>(string procedureName) where T : class
    {
        DataTable dt = ExecuteSPDataTable(procedureName);
        return dt.Rows.Count > 0 ? Extract<T>(dt.Rows[0]) : default;
    }

    public T ExecuteSQL<T>(string procedureName) where T : class
    {
        DataTable dt = ExecuteSQLDataTable(procedureName);
        return dt.Rows.Count > 0 ? Extract<T>(dt.Rows[0]) : default;
    }

    public int ExecuteNonQuery(string queryString) => Execute(command => command.ExecuteNonQuery(), CommandType.Text, queryString);
}
