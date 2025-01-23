using System;

class MultiplesBelow100
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"Multiples of {number} below 100:");
        for (int i = 100; i > 0; i--)
        {
            if (i % number == 0)
                Console.WriteLine(i);
        }
    }
}
