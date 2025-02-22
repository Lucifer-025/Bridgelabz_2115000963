using System;
using System.Text.RegularExpressions;

class RepeatingWordsFinder
{
    public static void FindRepeatingWords(string sentence)
    {
        string pattern = @"\b(\w+)\s+\1\b";
        MatchCollection matches = Regex.Matches(sentence, pattern, RegexOptions.IgnoreCase);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Groups[1].Value);
        }
    }

    public static void Main()
    {
        string sentence = "This is is a repeated repeated word test.";
        FindRepeatingWords(sentence);
    }
}
