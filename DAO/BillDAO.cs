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

    private BillDAO() { }

    public int GetUnCheckBillIDByTableID(int tableID)
    {
        DataProvider.Instance.AddInputParameter("TableID", tableID);
        BillDTO bill = DataProvider.Instance.ExecuteProcedure<BillDTO>("GetUnCheckBillIDByTableID");
        return bill != null ? bill.BillID : -1;
    }

    public void InsertBill(int tableID, int menuID, long price, int quantity)
    {
        DataProvider.Instance.AddInputParameter("TableID", tableID);
        DataProvider.Instance.AddInputParameter("MenuID", menuID);
        DataProvider.Instance.AddInputParameter("Price", price);
        DataProvider.Instance.AddInputParameter("Quantity", quantity);
        DataProvider.Instance.AddInputParameter("UserID", Core.AppContext.UserID);
        DataProvider.Instance.ExecuteProcedure<EmptyData>("SP_InsertBill");
    }

    public List<BillTempDTO> GetListTempBillByTableID(int tableID)
    {
        DataProvider.Instance.AddInputParameter("TableID", tableID);
        return DataProvider.Instance.ExecuteProcedureGetList<BillTempDTO>("SP_GetListTempBillByTableID");
    }
}
