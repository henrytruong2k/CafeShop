using CafeShop.Utils;
using System.Data;

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
        DataTable dtTable = DataProvider.Instance.ExecuteSPDataTable("SP_Login");

        if (dtTable == null || dtTable.Rows.Count == 0) return null;

        DataRow row = dtTable.Rows[0];
        AccountDTO account = AutoMapperConfig.Instance.Map<AccountDTO>(row);
        if (!PasswordUtil.VerifyPassword(username, password, account.Password)) return null;
        return account;
    }


}
