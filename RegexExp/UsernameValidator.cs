using System;
using System.Text.RegularExpressions;

class UsernameValidator
{
    public static bool IsValidUsername(string username)
    {
        string pattern = @"^[a-zA-Z][a-zA-Z0-9_]{4,14}$";
        return Regex.IsMatch(username, pattern);
    }

    public static void Main(string[] args)
    {
        string[] testUsernames = { "user_123", "123user", "us", "Valid_User" };
        foreach (var username in testUsernames)
        {
            Console.WriteLine($"{username} is {(IsValidUsername(username) ? "Valid" : "Invalid")}");
        }
    }
}
