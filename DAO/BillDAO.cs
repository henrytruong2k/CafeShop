using System.Text.Json.Serialization;
using System.Text.Json;

namespace CafeShop.DAO;

public class BillDAO
{
    private static readonly JsonSerializerOptions _options = new() { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull };
    private static BillDAO _instance;
    public static BillDAO Instance => _instance ??= new BillDAO();

    private BillDAO() { }

    public int GetUnCheckBillIDByTableID(int tableID)
    {
        DataProvider.Instance.AddInputParameter("TableID", tableID);
        BillDTO bill = DataProvider.Instance.ExecuteProcedure<BillDTO>("SP_GetUnCheckBillID");
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

    public void Checkout(int billID, long price, int discount, long totalPrice)
    {
        DataProvider.Instance.AddInputParameter("BillID", billID);
        DataProvider.Instance.AddInputParameter("Price", price);
        DataProvider.Instance.AddInputParameter("Discount", discount);
        DataProvider.Instance.AddInputParameter("TotalPrice", totalPrice);
        DataProvider.Instance.AddInputParameter("UserID", Core.AppContext.UserID);
        //TODO: fix typo parameters
        DataProvider.Instance.AddInputParameter("@Parameters", JsonSerializer.Serialize(new
        {
            BillID = billID,
            Price = price,
            Discount = discount,
            TotalPrice = totalPrice
        }, _options));
        DataProvider.Instance.ExecuteSPNonQuery("SP_CheckoutBill");
    }
}
