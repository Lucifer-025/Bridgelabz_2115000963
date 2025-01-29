using System;

class Compare
{
    static void CompareStrings(string str1, string str2)
    {
        int result = string.CompareOrdinal(str1, str2);
        if (result < 0)
            Console.WriteLine($"\"{str1}\" comes before \"{str2}\"");
        else if (result > 0)
            Console.WriteLine($"\"{str1}\" comes after \"{str2}\"");
        else
            Console.WriteLine("Both strings are equal.");
    }

    static void Main()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        CompareStrings(str1, str2);
    }
}
