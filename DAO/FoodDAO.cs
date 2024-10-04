using System.Data;

namespace CafeShop.DAO;

public class FoodDAO
{
    private static FoodDAO _instance;
    public static FoodDAO Instance
    {
        get
        {
            _instance ??= new FoodDAO();
            return _instance;
        }
        private set { _instance = value; }
    }

    public List<FoodDTO> GetListFood()
    {
        DataTable dataTable = DataProvider.Instance.ExecuteSPDataTable("SP_GetListFood");
        if (dataTable == null || dataTable.Rows.Count == 0) return null;
        List<FoodDTO> foods = AutoMapperConfig.Instance.Map<List<FoodDTO>>(dataTable);
        //foreach(DataRow item in dataTable.Rows)
        //{

        //}
        return foods;
    }



}
