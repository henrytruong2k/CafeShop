namespace CafeShop.BUS;

public class BillDetailBus
{
    private static BillDetailBus _instance;
    public static BillDetailBus Instance => _instance ??= new BillDetailBus();
    private BillDetailBus() { }

    public void InsertBillDetail(int billID, int menuID, long price, int quantity) => BillDetailDAO.Instance.InsertBillDetail(billID, menuID, price, quantity);
}
