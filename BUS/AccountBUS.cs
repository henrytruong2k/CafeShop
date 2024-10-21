namespace CafeShop.BUS;

public class AccountBUS
{
    private static AccountBUS _instance;
    public static AccountBUS Instance => _instance ??= new AccountBUS();
    private AccountBUS() { }
    public AccountDTO Login(string username, string password) => AccountDAO.Instance.Login(username, password);
}
