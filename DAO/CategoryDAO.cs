﻿using System.Text.Json;
using System.Text.Json.Serialization;

namespace CafeShop.DAO;

public class CategoryDAO
{
    private static readonly JsonSerializerOptions _options = new()
    {
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
    };
    private static CategoryDAO _instance;
    public static CategoryDAO Instance => _instance ??= new CategoryDAO();
    private CategoryDAO() { }
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
            DataProvider.Instance.AddInputParameter("Parameters", JsonSerializer.Serialize(cate, _options));
            DataProvider.Instance.ExecuteProcedure<EmptyData>("SP_AddCategory");
            return true;
        }
        catch
        {
            return false;
        }

    }
    public bool UpdateCategory(CategoryDTO cate)
    {
        try
        {
            DataProvider.Instance.AddInputParameter("CategoryID", cate.CategoryID);
            DataProvider.Instance.AddInputParameter("CategoryName", cate.CategoryName);
            DataProvider.Instance.AddInputParameter("Note", cate.Note);
            DataProvider.Instance.AddInputParameter("UserID", Core.AppContext.UserID);
            DataProvider.Instance.AddInputParameter("Parameters", JsonSerializer.Serialize(cate, _options));
            DataProvider.Instance.ExecuteProcedure<EmptyData>("SP_UpdateCategory");
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool DeleteCategory(int categoryID)
    {
        try
        {
            DataProvider.Instance.AddInputParameter("CategoryID", categoryID);
            DataProvider.Instance.AddInputParameter("UserID", Core.AppContext.UserID);
            DataProvider.Instance.AddInputParameter("Parameters", JsonSerializer.Serialize(new { CategoryID = categoryID }, _options));
            DataProvider.Instance.ExecuteProcedure<EmptyData>("SP_DeleteCategory");
            return true;
        }
        catch
        {
            return false;
        }
    }
}
