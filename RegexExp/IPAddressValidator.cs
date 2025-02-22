using System;
using System.Text.RegularExpressions;

class IPAddressValidator
{
    public static bool IsValidIP(string ip)
    {
        string pattern = @"^(25[0-5]|2[0-4][0-9]|[0-1]?[0-9][0-9]?)\.(\d{1,3})\.(\d{1,3})\.(\d{1,3})$";
        return Regex.IsMatch(ip, pattern);
    }

    public static void Main(string[] args)
    {
        string[] testIPs = { "192.168.1.1", "256.100.50.25", "123.456.78.90" };
        foreach (var ip in testIPs)
        {
            Console.WriteLine($"{ip} is {(IsValidIP(ip) ? "Valid" : "Invalid")}");
        }
    }
}

