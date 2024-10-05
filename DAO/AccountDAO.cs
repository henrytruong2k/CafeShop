using CafeShop.Utils;

namespace CafeShop.DAO;

public class AccountDAO
{
    private static AccountDAO _instance;
    public static AccountDAO Instance
    {
        get
        {
            _instance ??= new AccountDAO();
            return _instance;
        }
        private set { _instance = value; }
    }

    public AccountDTO Login(string username, string password)
    {
        DataProvider.Instance.AddInputParameter("UserName", username);
        AccountDTO account = DataProvider.Instance.ExecuteProcedure<AccountDTO>("SP_Login");
        if (!PasswordUtil.VerifyPassword(username, password, account?.Password)) return null;
        return account;
    }


}
