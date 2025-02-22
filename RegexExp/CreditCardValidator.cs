using System;
using System.Text.RegularExpressions;

class CreditCardValidator
{
    public static bool IsValidCreditCard(string cardNumber)
    {
        // Visa: starts with 4, MasterCard: starts with 5, 16 digits long
        string pattern = @"^(4|5)[0-9]{15}$";
        return Regex.IsMatch(cardNumber, pattern);
    }

    public static void Main()
    {
        Console.WriteLine(IsValidCreditCard("4111111111111111")); // Visa - True
        Console.WriteLine(IsValidCreditCard("5111111111111111")); // MasterCard - True
        Console.WriteLine(IsValidCreditCard("6111111111111111")); // Invalid - False
    }
}

