using System;
using System.Linq;

class Frequent
{
    static char MostFrequentCharacter(string input)
    {
        return input.GroupBy(c => c).OrderByDescending(g => g.Count()).First().Key;
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.WriteLine("Most Frequent Character: " + MostFrequentCharacter(input));
    }
}
