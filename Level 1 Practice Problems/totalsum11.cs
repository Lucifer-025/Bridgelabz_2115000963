using System;

class totalsum11
{
    static void Main()
    {
        double total = 0;

        while (true)
        {
            Console.Write("Enter a number (0 or negative to stop): ");
            double number = double.Parse(Console.ReadLine());

            if (number <= 0) break;

            total += number;
        }

        Console.WriteLine($"The total sum is {total}");
    }
}
