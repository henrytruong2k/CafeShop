namespace CafeShop.BUS;

public class TableBUS
{
    private static TableBUS _instance;
    public static TableBUS Instance => _instance ??= new TableBUS();
    public List<TableDTO> LoadTables() => TableDAO.Instance.LoadTables();
    public List<TableDTO> LoadTables(int tableID) => TableDAO.Instance.LoadTables(tableID);
    public List<TableDTO> LoadMergeableTables(int tableID) => TableDAO.Instance.LoadMergeableTables(tableID);
    public void SwitchTable(int tableID1, int tableID2) => TableDAO.Instance.SwitchTable(tableID1, tableID2);
    public void MergeTable(int tableID1, int tableID2) => TableDAO.Instance.MergeTable(tableID1, tableID2);

    public List<TableDTO> GetTables() => TableDAO.Instance.GetTables();

    public List<TableDTO> GetTable(string tableName) => TableDAO.Instance.GetTable(tableName);

    public bool InsertTable(TableDTO tableDTO) => TableDAO.Instance.InsertTable(tableDTO);

    public bool UpdateTable(TableDTO tableDTO) => TableDAO.Instance.UpdateTable(tableDTO);

    public bool DeleteTable(int tableID) => TableDAO.Instance.DeleteTable(tableID);



}