namespace CafeShop.BUS;

public class HistoryLogBUS
{
    private static HistoryLogBUS _instance;

    public static HistoryLogBUS Instance
    {
        get
        {
            _instance ??= new HistoryLogBUS();
            return _instance;
        }
        private set {_instance = value; }
    }
    public List<HistoryLogDTO> GetHistoryLogs() => HistoryLogDAO.Instance.GetHistoryLogs();


}
