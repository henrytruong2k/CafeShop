namespace CafeShop.DAO;

public class MenuDAO
{
    private static MenuDAO _instance;
    public static MenuDAO Instance
    {
        get
        {
            _instance ??= new MenuDAO();
            return _instance;
        }
        private set { _instance = value; }
    }

    public List<MenuDTO> GetMenus(string menuName)
    {
        DataProvider.Instance.AddInputParameter("MenuName", menuName);
        List<MenuDTO> menus = DataProvider.Instance.ExecuteProcedureGetList<MenuDTO>("SP_MenuSearch");
        return menus;
    }
}
