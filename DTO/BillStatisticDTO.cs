using CafeShop.Utils;

namespace CafeShop.DTO;

public class BillStatisticDTO
{
    private long _price;
    private long _totalPrice;
    private DateTime _dateCheckin;
    private DateTime _dateCheckout;

    public string TableName { get; set; }
    public string DateCheckin
    {
        get => _dateCheckin.ToString("dd-MM-yyyy HH:mm:ss");
        set => _dateCheckin = ParseDateTime(value);
    }
    public string DateCheckout
    {
        get => _dateCheckout.ToString("dd-MM-yyyy HH:mm:ss");
        set => _dateCheckout = ParseDateTime(value);
    }
    public string Price
    {
        get => _price.ToVND();
        set => _price = ParseLong(value);
    }

    public int Discount { get; set; }
    public string TotalPrice
    {
        get => _totalPrice.ToVND();
        set => _totalPrice = ParseLong(value);
    }
    private long ParseLong(string value)
    {
        return long.TryParse(value, out long parsedValue) ? parsedValue : 0;
    }

    private DateTime ParseDateTime(string value)
    {
        return DateTime.TryParse(value, out DateTime parsedDate) ? parsedDate : DateTime.MinValue;
    }
}
