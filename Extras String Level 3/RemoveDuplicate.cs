using System;
using System.Linq;

class RemoveDuplicate
{
    static string RemoveDuplicates(string input)
    {
        return new string(input.Distinct().ToArray());
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.WriteLine("Modified String: " + RemoveDuplicates(input));
    }
}
