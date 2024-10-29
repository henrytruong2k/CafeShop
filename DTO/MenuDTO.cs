namespace CafeShop.DTO;

public class MenuDTO
{
    public int MenuID { get; set; }
    public string MenuName { get; set; }
    public string Description { get; set; }
    public long Price { get; set; }
    public int CategoryID { get; set; }
    public string CategoryName { get; set; }
}

public class BestMenuDTO
{
    public string MenuName { get; set; }
    public string TotalQuantity { get; set; }
}