using System;

class NumberAnalysis
{
    static void Main(string[] args)
    {
        int number = 21; // Example number for testing
        Console.WriteLine("Number: " + number);
        Console.WriteLine("Count of Digits: " + CountDigits(number));
        Console.WriteLine("Sum of Digits: " + SumOfDigits(number));
        Console.WriteLine("Sum of Squares of Digits: " + SumOfSquaresOfDigits(number));
        Console.WriteLine("Is Harshad Number: " + IsHarshadNumber(number));
        FindDigitFrequency(number);
    }

    static int CountDigits(int num)
    {
        return num.ToString().Length;
    }

    static int SumOfDigits(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }
        return sum;
    }

    static int SumOfSquaresOfDigits(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            int digit = num % 10;
            sum += (int)Math.Pow(digit, 2);
            num /= 10;
        }
        return sum;
    }

    static bool IsHarshadNumber(int num)
    {
        int sum = SumOfDigits(num);
        return num % sum == 0;
    }

    static void FindDigitFrequency(int num)
    {
        int[] frequency = new int[10];
        while (num > 0)
        {
            frequency[num % 10]++;
            num /= 10;
        }
        Console.WriteLine("Digit Frequencies:");
        for (int i = 0; i < frequency.Length; i++)
        {
            if (frequency[i] > 0)
                Console.WriteLine($"{i}: {frequency[i]}");
        }
    }
}

