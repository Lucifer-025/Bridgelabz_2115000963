using System;

class FactorsFinder
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"Factors of {number}:");
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
                Console.WriteLine(i);
        }
    }
}
