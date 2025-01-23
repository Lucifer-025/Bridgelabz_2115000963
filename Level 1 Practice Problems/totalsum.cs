using System;

class totalsum
{
    static void Main()
    {
        double total = 0;
        double number;

        do
        {
            Console.Write("Enter a number (0 to stop): ");
            number = double.Parse(Console.ReadLine());
            total += number;
        } while (number != 0);

        Console.WriteLine($"The total sum is {total}");
    }
}
