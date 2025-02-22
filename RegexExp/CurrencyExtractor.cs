using System;
using System.Text.RegularExpressions;

class CurrencyExtractor
{
    public static void ExtractCurrency(string text)
    {
        string pattern = @"\$\s?\d+(\.\d{2})?";
        MatchCollection matches = Regex.Matches(text, pattern);
        
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value.Trim());
        }
    }

    public static void Main()
    {
        string text = "The price is $45.99, and the discount is $ 10.50.";
        ExtractCurrency(text);
    }
}
