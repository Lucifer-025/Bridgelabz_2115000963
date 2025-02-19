using System;
using System.Collections.Generic;

class Frequency
{
    static Dictionary<string, int> FindFrequency(List<string> words)
    {
        Dictionary<string, int> freq = new Dictionary<string, int>();
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
        List<string> words = new List<string> { "apple", "banana", "apple", "orange" };
        var result = FindFrequency(words);
        foreach (var kvp in result)
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
    }
}
