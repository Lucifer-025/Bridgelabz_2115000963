using System;

class largsetandsecond
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
        int maxDigit = 10, index = 0;

        while (number != 0)
        {
            if (index == maxDigit)
            {
                maxDigit += 10;
                Array.Resize(ref digits, maxDigit);
            }

            digits[index++] = number % 10;
            number /= 10;
        }

        int largest = 0, secondLargest = 0;
        for (int i = 0; i < index; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
            {
                secondLargest = digits[i];
            }
        }

        Console.WriteLine($"Largest digit: {largest}");
        Console.WriteLine($"Second largest digit: {secondLargest}");
    }
}
