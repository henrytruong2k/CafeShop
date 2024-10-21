namespace CafeShop.BUS;

public class BillBUS
{
    private static BillBUS _instance;
    public static BillBUS Instance
    {
        get
        {
            _instance ??= new BillBUS();
            return _instance;
        }
        private set { _instance = value; }
    }

    private BillBUS() { }

    public int GetUnCheckBillIDByTableID(int id) => BillDAO.Instance.GetUnCheckBillIDByTableID(id);

    public void InsertBill(int tableID, int menuID, long price, int quantity) => BillDAO.Instance.InsertBill(tableID, menuID, price, quantity);

    public List<BillTempDTO> GetListTempBillByTableID(int tableID) => BillDAO.Instance.GetListTempBillByTableID(tableID);
    public void Checkout(int billID, long price, int discount, long totalPrice) => BillDAO.Instance.Checkout(billID, price, discount, totalPrice);

    public (List<BillStatisticDTO>, int) GetListBillByDate(string fromDate, string toDate, int offset, int limit) => BillDAO.Instance.GetListBillByDate(fromDate, toDate, offset, limit);
}
