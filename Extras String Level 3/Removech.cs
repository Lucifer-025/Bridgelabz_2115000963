using System;

class Removech
{
    static string RemoveCharacter(string input, char charToRemove)
    {
        return new string(input.Where(c => c != charToRemove).ToArray());
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.Write("Enter character to remove: ");
        char charToRemove = Console.ReadKey().KeyChar;
        Console.WriteLine();

        Console.WriteLine("Modified String: " + RemoveCharacter(input, charToRemove));
    }
}
