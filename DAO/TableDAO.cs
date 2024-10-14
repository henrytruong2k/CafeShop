namespace CafeShop.DAO;

public class TableDAO
{
    private static TableDAO _instance;
    public static TableDAO Instance
    {
        get
        {
            _instance ??= new TableDAO();
            return _instance;
        }
        private set { _instance = value; }
    }

    public List<TableDTO> LoadTables() => DataProvider.Instance.ExecuteSQLGetList<TableDTO>("SELECT * FROM V_LoadTables");
}
