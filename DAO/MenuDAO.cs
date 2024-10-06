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

    public List<CategoryDTO> GetCategories() => DataProvider.Instance.ExecuteSQLGetList<CategoryDTO>("SELECT * FROM Categories");

    public bool InsertMenu(MenuDTO menu)
    {
        string query = $"INSERT INTO Menus(MenuName, Price) VALUES (N'{menu.MenuName}', {menu.Price})";
        return DataProvider.Instance.ExecuteNonQuery(query) > 0;
    }
}
