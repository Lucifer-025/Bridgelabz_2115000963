using System;
using System.Text.RegularExpressions;

class LinkExtractor
{
    public static void ExtractLinks(string text)
    {
        string pattern = @"https?://[^\s]+";
        MatchCollection matches = Regex.Matches(text, pattern);
        
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }

    public static void Main(string[] args)
    {
        string text = "Visit https://www.google.com and http://example.org for more info.";
        ExtractLinks(text);
    }
}
