using System;

class Vowelsandconsonents
{
    static void CountVowelsAndConsonants(string input, out int vowels, out int consonants)
    {
        vowels = 0;
        consonants = 0;
        string vowelSet = "aeiouAEIOU";

        foreach (char ch in input)
        {
            if (char.IsLetter(ch))
            {
                if (vowelSet.Contains(ch))
                    vowels++;
                else
                    consonants++;
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        CountVowelsAndConsonants(input, out int vowels, out int consonants);

        Console.WriteLine($"Vowels: {vowels}");
        Console.WriteLine($"Consonants: {consonants}");
    }
}
