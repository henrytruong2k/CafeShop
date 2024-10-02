using BCryptNet = BCrypt.Net.BCrypt;

namespace CafeShop.Utils;

public static class PasswordUtil
{
    public static string HashPassword(string username, string password)
    {
        if (string.IsNullOrEmpty(password))
        {
            throw new ArgumentException("Password can't be empty");
        }
        return BCryptNet.HashPassword(username + password);
    }

    public static bool VerifyPassword(string username, string password, string passwordHash)
    {
        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(passwordHash))
            return false;
        return BCryptNet.Verify(username + password, passwordHash);
    }
}