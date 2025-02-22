using System;
using System.Text.RegularExpressions;

class CapitalizedWordsExtractor
{
    public static void ExtractCapitalizedWords(string text)
    {
        string pattern = @"\b[A-Z][a-z]*\b";
        MatchCollection matches = Regex.Matches(text, pattern);
        
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }

    public static void Main(string[] args)
    {
        string text = "The Eiffel Tower is in Paris and the Statue of Liberty is in New York.";
        ExtractCapitalizedWords(text);
    }
}
