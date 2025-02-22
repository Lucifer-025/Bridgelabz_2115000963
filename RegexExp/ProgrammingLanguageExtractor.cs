using System;
using System.Text.RegularExpressions;

class ProgrammingLanguageExtractor
{
    public static void ExtractLanguages(string text)
    {
        string pattern = @"\b(JavaScript|Java|Python|Go|C#|Ruby|Swift|Kotlin|PHP)\b";
        MatchCollection matches = Regex.Matches(text, pattern);
        
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }

    public static void Main()
    {
        string text = "I love Java, Python, and JavaScript, but I haven't tried Go yet.";
        ExtractLanguages(text);
    }
}

