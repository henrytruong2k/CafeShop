namespace CafeShop.DAO;

public class TableDAO
{
    private static TableDAO _instance;
    public static TableDAO Instance => _instance ??= new TableDAO();
    private TableDAO() { }
    public List<TableDTO> LoadTables() => DataProvider.Instance.ExecuteSQLGetList<TableDTO>("SELECT * FROM TableFood WHERE Status = 1");
    public List<TableDTO> LoadSwitchableTables(int tableID) => DataProvider.Instance.ExecuteSQLGetList<TableDTO>($"SELECT TableID, TableName from TableFood WHERE TableID <> {tableID} AND Status = 1");

    public void SwitchTable(int tableID1, int tableID2)
    {
        DataProvider.Instance.AddInputParameter("TableID1", tableID1);
        DataProvider.Instance.AddInputParameter("TableID2", tableID2);
        DataProvider.Instance.ExecuteSPNonQuery("SP_SwitchTable");
    }
}
