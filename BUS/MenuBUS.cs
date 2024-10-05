namespace CafeShop.BUS;

public class MenuBUS
{
    private static MenuBUS _instance;
    public static MenuBUS Instance
    {
        get
        {
            _instance ??= new MenuBUS();
            return _instance;
        }
        private set { _instance = value; }
    }
    
    public List<MenuDTO> GetMenus(string menuName = null) => MenuDAO.Instance.GetMenus(menuName);
}
