namespace CafeShop.BUS;

public class CategoryBUS
{
    private static CategoryBUS _instance;
    public static CategoryBUS Instance
    {
        get
        {
            _instance ??= new CategoryBUS();
            return _instance;
        }
        private set { _instance = value; }
    }

    public List<CategoryDTO> GetCategories() => CategoryDAO.Instance.GetCategories();

    public List<CategoryDTO> GetCategory(string cateName) => CategoryDAO.Instance.GetCategory(cateName);

    public bool InsertCategory(CategoryDTO cateDTO) => CategoryDAO.Instance.InsertCategory(cateDTO);
}
