namespace CafeShop.BUS;

public class CategoryBUS
{
    private static CategoryBUS _instance;
    public static CategoryBUS Instance => _instance ??= new CategoryBUS();

    public List<CategoryDTO> GetCategories() => CategoryDAO.Instance.GetCategories();

    public List<CategoryDTO> GetCategory(string cateName) => CategoryDAO.Instance.GetCategory(cateName);

    public bool InsertCategory(CategoryDTO cateDTO) => CategoryDAO.Instance.InsertCategory(cateDTO);

    public bool UpdateCategory(CategoryDTO cateDTO) => CategoryDAO.Instance.UpdateCategory(cateDTO);

    public bool DeleteCategory(int categoryID) => CategoryDAO.Instance.DeleteCategory(categoryID);
}
