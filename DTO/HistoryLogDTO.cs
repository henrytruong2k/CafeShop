namespace CafeShop.DTO;

public class HistoryLogDTO
{
    public int LogID { get; set; }
    public string LogTable { get; set; }
    public int ObjectID { get; set; }
    public string Parameters { get; set; }

    private DateTime _logtime;
    public string LogTime
    {
        get => _logtime.ToString("dd-MM-yyyy HH:mm:ss");
        set => _logtime = ParseDateTime(value);
    }
    private DateTime ParseDateTime(string value)
    {
        return DateTime.TryParse(value, out DateTime parsedDate) ? parsedDate : DateTime.MinValue;
    }
    public string LogAction { get; set; }
    public int UserID { get; set; }
}
