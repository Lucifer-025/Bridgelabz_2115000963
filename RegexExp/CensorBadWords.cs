using System;
using System.Text.RegularExpressions;

class CensorBadWords
{
    public static string Censor(string text)
    {
        string pattern = @"\b(damn|stupid)\b";
        return Regex.Replace(text, pattern, "****", RegexOptions.IgnoreCase);
    }

    public static void Main(string[] args)
    {
        string text = "This is a damn bad example with some stupid words.";
        Console.WriteLine(Censor(text));
    }
}
