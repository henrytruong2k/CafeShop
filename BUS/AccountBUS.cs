namespace CafeShop.BUS;

public class AccountBUS
{
    private static AccountBUS _instance;
    public static AccountBUS Instance
    {
        get
        {
            _instance ??= new AccountBUS();
            return _instance;
        }
        private set { _instance = value; }
    }

    public AccountDTO Login(string username, string password) => AccountDAO.Instance.Login(username, password);
    
}
