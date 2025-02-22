using System;
using System.Text.RegularExpressions;

class SSNValidator
{
    public static bool IsValidSSN(string ssn)
    {
        string pattern = @"^\d{3}-\d{2}-\d{4}$";
        return Regex.IsMatch(ssn, pattern);
    }

    public static void Main()
    {
        Console.WriteLine(IsValidSSN("123-45-6789")); // Valid - True
        Console.WriteLine(IsValidSSN("123456789"));    // Invalid - False
    }
}
