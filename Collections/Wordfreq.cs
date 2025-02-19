using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Wordfreq
{
    static Dictionary<string, int> WordFrequency(string text)
    {
        Dictionary<string, int> freq = new Dictionary<string, int>();
        string[] words = text.ToLower().Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in words)
        {
            if (freq.ContainsKey(word))
                freq[word]++;
            else
                freq[word] = 1;
        }

        return freq;
    }

    static void Main()
    {
        string text = "Hello world, hello Java!";
        var result = WordFrequency(text);
        foreach (var kvp in result)
            Console.WriteLine(kvp.Key+" " +kvp.Value);
    }
}
