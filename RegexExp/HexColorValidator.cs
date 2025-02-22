using System;
using System.Text.RegularExpressions;

class HexColorValidator
{
    public static bool IsValidHexColor(string color)
    {
        string pattern = @"^#([A-Fa-f0-9]{6})$";
        return Regex.IsMatch(color, pattern);
    }

    public static void Main(string[] args)
    {
        string[] testColors = { "#FFA500", "#ff4500", "#123", "#ZZZZZZ" };
        foreach (var color in testColors)
        {
            Console.WriteLine($"{color} is {(IsValidHexColor(color) ? "Valid" : "Invalid")}");
        }
    }
}
