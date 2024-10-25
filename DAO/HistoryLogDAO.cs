namespace CafeShop.DAO;

public class HistoryLogDAO
{
    private static HistoryLogDAO _instance;
    public static HistoryLogDAO Instance => _instance ??= new HistoryLogDAO();
    private HistoryLogDAO() { }

    public List<HistoryLogDTO> GetHistoryLogs()
    {
        DataProvider.Instance.AddInputParameter("UserID", Core.AppContext.UserID);
        return DataProvider.Instance.ExecuteProcedureGetList<HistoryLogDTO>("SP_GetHistoryLog");
    }
}
