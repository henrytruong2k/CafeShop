using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CafeShop.DAO;

public class CategoryDAO
{
    private static readonly JsonSerializerOptions _options = new() { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull };
    private static CategoryDAO _instance;
    public static CategoryDAO Instance
    {
        get
        {
            _instance ??= new CategoryDAO();
            return _instance;
        }
        private set { _instance = value; }
    }

    public List<CategoryDTO> GetCategories() => DataProvider.Instance.ExecuteProcedureGetList<CategoryDTO>("SP_GetCategories");

    public List<CategoryDTO> GetCategory(string cateName)
    {
        DataProvider.Instance.AddInputParameter("CategoryName", cateName);
        List<CategoryDTO> cate = DataProvider.Instance.ExecuteProcedureGetList<CategoryDTO>("SP_CategorySearch");
        return cate;
    }

    public bool InsertCategory(CategoryDTO cate)
    {
        try
        {
            DataProvider.Instance.AddInputParameter("CategoryName", cate.CategoryName);
            DataProvider.Instance.AddInputParameter("Note", cate.Note);
            DataProvider.Instance.AddInputParameter("UserID", Core.AppContext.UserID);
            DataProvider.Instance.AddInputParameter("Paramerters", JsonSerializer.Serialize(cate, _options));
            DataProvider.Instance.ExecuteProcedure<EmptyData>("SP_AddCategory");
            return true;
        }
        catch
        {
            return false;
        }


    }
}
