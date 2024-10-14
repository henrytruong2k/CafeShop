namespace CafeShop.BUS;

public class TableBUS
{
    private static TableBUS _instance;
    public static TableBUS Instance
    {
        get
        {
            _instance ??= new TableBUS();
            return _instance;
        }
        private set { _instance = value; }
    }

    public List<TableDTO> LoadTables() => TableDAO.Instance.LoadTables();
}