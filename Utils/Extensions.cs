using System.Globalization;

namespace CafeShop.Utils;

public static class StringExtensions
{
    public static string RemoveCommas(this string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input;
        }
        return input.Replace(",", "");
    }
}

public static class LongExtensions
{
    public static string ToVND(this long value)
    {
        CultureInfo culture = new("vi-VN");
        return value.ToString("c", culture); //c: currency
    }
}