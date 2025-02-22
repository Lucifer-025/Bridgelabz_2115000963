using System;
using System.Text.RegularExpressions;

class LicensePlateValidator
{
    public static bool IsValidLicensePlate(string plate)
    {
        string pattern = @"^[A-Z]{2}\d{4}$";
        return Regex.IsMatch(plate, pattern);
    }

    public static void Main(string[] args)
    {
        string[] testPlates = { "AB1234", "A12345", "XY6789", "Z123" };
        foreach (var plate in testPlates)
        {
            Console.WriteLine($"{plate} is {(IsValidLicensePlate(plate) ? "Valid" : "Invalid")}");
        }
    }
}
