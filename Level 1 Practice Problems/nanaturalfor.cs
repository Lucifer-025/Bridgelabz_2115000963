using System;

class nnaturalfor
{
    static void Main()
    {
        Console.Write("Enter a natural number: ");
        int number = int.Parse(Console.ReadLine());

        if (number > 0)
        {
            int sumFormula = number * (number + 1) / 2;
            int sumLoop = 0;

            for (int i = 1; i <= number; i++)
            {
                sumLoop += i;
            }

            Console.WriteLine($"Sum using formula: {sumFormula}");
            Console.WriteLine($"Sum using for loop: {sumLoop}");
        }
        else
        {
            Console.WriteLine("Not a natural number.");
        }
    }
}
