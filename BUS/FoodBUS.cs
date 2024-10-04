namespace CafeShop.BUS;

public class FoodBUS
{
    private static FoodBUS _instance;
    public static FoodBUS Instance
    {
        get
        {
            _instance ??= new FoodBUS();
            return _instance;
        }
        private set { _instance = value; }
    }
    
    public List<FoodDTO> GetListFood() => FoodDAO.Instance.GetListFood();
}
