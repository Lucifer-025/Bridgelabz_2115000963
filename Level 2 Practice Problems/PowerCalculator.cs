using System;

class PowerCalculator
{
    static void Main()
    {
        Console.WriteLine("Enter a base number:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the power:");
        int power = int.Parse(Console.ReadLine());

        int result = 1;
        for (int i = 1; i <= power; i++)
        {
            result *= number;
        }

        Console.WriteLine($"{number} raised to the power {power} is {result}");
    }
}
