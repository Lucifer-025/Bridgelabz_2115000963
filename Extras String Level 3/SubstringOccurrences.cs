using System;

class SubstringOccurrences
{
    static int CountSubstringOccurrences(string input, string substring)
    {
        int count = 0, index = 0;
        while ((index = input.IndexOf(substring, index)) != -1)
        {
            count++;
            index += substring.Length;
        }
        return count;
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.Write("Enter substring: ");
        string substring = Console.ReadLine();

        Console.WriteLine("Occurrences: " + CountSubstringOccurrences(input, substring));
    }
}
