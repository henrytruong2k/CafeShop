namespace CafeShop.BUS;

public class TableBUS
{
    private static TableBUS _instance;
    public static TableBUS Instance => _instance ??= new TableBUS();
    public List<TableDTO> LoadTables() => TableDAO.Instance.LoadTables();
    public List<TableDTO> LoadSwitchableTables(int tableID) => TableDAO.Instance.LoadSwitchableTables(tableID);
    public void SwitchTable(int tableID1, int tableID2) => TableDAO.Instance.SwitchTable(tableID1, tableID2);
}