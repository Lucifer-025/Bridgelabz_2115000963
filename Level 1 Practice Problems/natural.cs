using System;

class natural
{
    static void Main()
    {
        Console.Write("Enter a natural number: ");
        int number = int.Parse(Console.ReadLine());

        if (number > 0)
        {
            int sumFormula = number * (number + 1) / 2;
            int sumLoop = 0;
            int i = 1;

            while (i <= number)
            {
                sumLoop += i;
                i++;
            }

            Console.WriteLine($"Sum using formula: {sumFormula}");
            Console.WriteLine($"Sum using while loop: {sumLoop}");
        }
        else
        {
            Console.WriteLine("Not a natural number.");
        }
    }
}
