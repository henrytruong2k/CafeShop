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
