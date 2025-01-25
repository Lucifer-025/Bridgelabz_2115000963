using System;

class frequency
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number;
        while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
        {
            Console.WriteLine("Invalid input. Enter a positive number:");
        }

        int[] frequency = new int[10];

        while (number != 0)
        {
            int digit = number % 10;
            frequency[digit]++;
            number /= 10;
        }

        Console.WriteLine("Digit Frequency:");
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i] > 0)
            {
                Console.WriteLine($"Digit {i}: {frequency[i]} times");
            }
        }
    }
}
