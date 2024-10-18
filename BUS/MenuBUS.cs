﻿namespace CafeShop.BUS;

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

    private MenuBUS() { }
    
    public List<MenuDTO> GetMenus(string menuName = null) => MenuDAO.Instance.GetMenus(menuName);

    public List<MenuDTO> GetMenusByCategoryID(int categoryID) => MenuDAO.Instance.GetMenuByCategoryID(categoryID);

    public List<CategoryDTO> GetCategories() => MenuDAO.Instance.GetCategories();
    public bool InsertMenu(MenuDTO menuDTO) => MenuDAO.Instance.InsertMenu(menuDTO);
    public bool UpdateMenu(MenuDTO menuDTO) => MenuDAO.Instance.UpdateMenu(menuDTO);
    public bool DeleteMenu(int menuID) => MenuDAO.Instance.DeleteMenu(menuID);
}
