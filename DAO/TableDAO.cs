using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CafeShop.DAO;

public class TableDAO
{
    private static readonly JsonSerializerOptions _options = new();
    private static TableDAO _instance;
    public static TableDAO Instance => _instance ??= new TableDAO();
    private TableDAO() { }
    public List<TableDTO> LoadTables() => DataProvider.Instance.ExecuteSQLGetList<TableDTO>("SELECT * FROM TableFood WHERE Status = 1");
    public List<TableDTO> LoadTables(int tableID) => DataProvider.Instance.ExecuteSQLGetList<TableDTO>($"SELECT TableID, TableName from TableFood WHERE TableID <> {tableID} AND Status = 1");

    public List<TableDTO> LoadMergeableTables(int tableID) => DataProvider.Instance.ExecuteSQLGetList<TableDTO>($"SELECT TableID, TableName from TableFood WHERE TableID <> {tableID} AND Status = 1 AND BookingStatus = 1");

    public void SwitchTable(int tableID1, int tableID2)
    {
        DataProvider.Instance.AddInputParameter("TableID1", tableID1);
        DataProvider.Instance.AddInputParameter("TableID2", tableID2);
        DataProvider.Instance.ExecuteSPNonQuery("SP_SwitchTable");
    }
    public void MergeTable(int tableID1, int tableID2)
    {
        DataProvider.Instance.AddInputParameter("TableID1", tableID1);
        DataProvider.Instance.AddInputParameter("TableID2", tableID2);
        DataProvider.Instance.ExecuteSPNonQuery("SP_MergeTable");
    }

    public List<TableDTO> GetTables() => DataProvider.Instance.ExecuteProcedureGetList<TableDTO>("SP_GetTables");

    public List<TableDTO> GetTable(string tableName)
    {
        DataProvider.Instance.AddInputParameter("TableName", tableName);
        List<TableDTO> table = DataProvider.Instance.ExecuteProcedureGetList<TableDTO>("SP_TableSearch");
        return table;
    }

    public bool InsertTable(TableDTO table)
    {
        try
        {
            DataProvider.Instance.AddInputParameter("TableName", table.TableName);
            //DataProvider.Instance.AddInputParameter("BookingStatus", table.BookingStatus);
            DataProvider.Instance.AddInputParameter("UserID", Core.AppContext.UserID);
            DataProvider.Instance.AddInputParameter("Parameters", JsonSerializer.Serialize(table, _options));
            DataProvider.Instance.ExecuteProcedure<EmptyData>("SP_InsertTable");
            return true;
        }
        catch
        {
            return false;
        }

    }
    public bool UpdateTable(TableDTO table)
    {
        try
        {
            DataProvider.Instance.AddInputParameter("TableID", table.TableID);
            DataProvider.Instance.AddInputParameter("TableName", table.TableName);
            //DataProvider.Instance.AddInputParameter("BookingStatus", table.BookingStatus);
            DataProvider.Instance.AddInputParameter("UserID", Core.AppContext.UserID);
            DataProvider.Instance.AddInputParameter("Parameters", JsonSerializer.Serialize(table, _options));
            DataProvider.Instance.ExecuteProcedure<EmptyData>("SP_UpdateTable");
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool DeleteTable(int tableID)
    {
        try
        {
            DataProvider.Instance.AddInputParameter("TableID", tableID);
            DataProvider.Instance.AddInputParameter("UserID", Core.AppContext.UserID);
            DataProvider.Instance.AddInputParameter("Parameters", JsonSerializer.Serialize(new { TableID = tableID }, _options));
            DataProvider.Instance.ExecuteProcedure<EmptyData>("SP_DeleteTable");
            return true;
        }
        catch
        {
            return false;
        }
    }

}
