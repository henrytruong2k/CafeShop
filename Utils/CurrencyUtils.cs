namespace CafeShop.Utils;

public static class CurrencyUtils
{
    public static void FormatVND(TextBox txt)
    {
        int cursorPosition = txt.SelectionStart;
        string value = txt.Text.Replace(",", "");

        if (decimal.TryParse(value, out decimal amount))
        {
            txt.Text = string.Format("{0:N0}", amount);
            txt.SelectionStart = cursorPosition + (txt.Text.Length - value.Length);
        }
    }
}
