namespace CafeShop.DAO;

public class BillDetailDAO
{
    private static BillDetailDAO _instance;
    public static BillDetailDAO Instance
    {
        get
        {
            _instance ??= new BillDetailDAO();
            return _instance;
        }
        private set { _instance = value; }
    }

    private BillDetailDAO() { }

    public void InsertBillDetail(int billID, int menuID, long price, int quantity)
    {
        DataProvider.Instance.AddInputParameter("BillID", billID);
        DataProvider.Instance.AddInputParameter("MenuID ", menuID);
        DataProvider.Instance.AddInputParameter("Price ", price);
        DataProvider.Instance.AddInputParameter("Quantity", quantity);
        DataProvider.Instance.ExecuteSPNonQuery("SP_InsertBillDetail");
    }
}
