namespace CafeShop.DAO;

public class BillDAO
{
    private static BillDAO _instance;
    public static BillDAO Instance
    {
        get
        {
            _instance ??= new BillDAO();
            return _instance;
        }
        private set { _instance = value; }
    }
}
