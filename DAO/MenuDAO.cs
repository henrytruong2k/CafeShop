using System.Text.Json;
using System.Text.Json.Serialization;

namespace CafeShop.DAO;

public class MenuDAO
{
    private static readonly JsonSerializerOptions _options = new() { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull };
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

    public List<MenuDTO> GetMenuByCategoryID(int categoryID)
    {
        DataProvider.Instance.AddInputParameter("CategoryID", categoryID);
        return DataProvider.Instance.ExecuteProcedureGetList<MenuDTO>("SP_GetMenuByCategoryID");
    }

    public List<CategoryDTO> GetCategories() => DataProvider.Instance.ExecuteSQLGetList<CategoryDTO>("SELECT * FROM Categories");

    public bool InsertMenu(MenuDTO menu)
    {
        try
        {
            DataProvider.Instance.AddInputParameter("MenuName", menu.MenuName);
            DataProvider.Instance.AddInputParameter("Description", menu.Description);
            DataProvider.Instance.AddInputParameter("Price", menu.Price);
            DataProvider.Instance.AddInputParameter("CategoryID", menu.CategoryID);
            DataProvider.Instance.AddInputParameter("UserID", Core.AppContext.UserID);
            DataProvider.Instance.AddInputParameter("Paramerters", JsonSerializer.Serialize(menu, _options));
            DataProvider.Instance.ExecuteProcedure<EmptyData>("SP_InsertMenu");
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool UpdateMenu(MenuDTO menu)
    {
        try
        {
            DataProvider.Instance.AddInputParameter("MenuID", menu.MenuID);
            DataProvider.Instance.AddInputParameter("MenuName", menu.MenuName);
            DataProvider.Instance.AddInputParameter("Description", menu.Description);
            DataProvider.Instance.AddInputParameter("Price", menu.Price);
            DataProvider.Instance.AddInputParameter("CategoryID", menu.CategoryID);
            DataProvider.Instance.AddInputParameter("UserID", Core.AppContext.UserID);
            DataProvider.Instance.AddInputParameter("Paramerters", JsonSerializer.Serialize(menu, _options));
            DataProvider.Instance.ExecuteProcedure<EmptyData>("SP_UpdateMenu");
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool DeleteMenu(int menuID)
    {
        try
        {
            DataProvider.Instance.AddInputParameter("MenuID", menuID);
            DataProvider.Instance.AddInputParameter("UserID", Core.AppContext.UserID);
            DataProvider.Instance.AddInputParameter("Paramerters", JsonSerializer.Serialize(new { MenuID = menuID }, _options));
            DataProvider.Instance.ExecuteProcedure<EmptyData>("SP_DeleteMenu");
            return true;
        }
        catch
        {
            return false;
        }
    }
}