using System;

class reverse
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number;
        while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
        {
            Console.WriteLine("Invalid input. Enter a positive number:");
        }

        int[] digits = new int[10];
        int index = 0;

        while (number != 0)
        {
            if (index == digits.Length)
            {
                Array.Resize(ref digits, digits.Length + 10);
            }

            digits[index++] = number % 10;
            number /= 10;
        }

        Console.WriteLine("Reversed Number:");
        for (int i = index - 1; i >= 0; i--)
        {
            Console.Write(digits[i]);
        }
    }
}
