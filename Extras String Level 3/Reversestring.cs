using System;

class Reversestring
{
    static string ReverseString(string input)
    {
        char[] reversed = new char[input.Length];
        for (int i = 0, j = input.Length - 1; i < input.Length; i++, j--)
        {
            reversed[i] = input[j];
        }
        return new string(reversed);
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.WriteLine("Reversed String: " + ReverseString(input));
    }
}
