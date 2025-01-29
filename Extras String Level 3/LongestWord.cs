using System;
using System.Linq;

class LongestWord
{
    static string FindLongestWord(string sentence)
    {
        string[] words = sentence.Split(' ');
        return words.OrderByDescending(w => w.Length).FirstOrDefault();
    }

    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        Console.WriteLine("Longest Word: " + FindLongestWord(sentence));
    }
}
