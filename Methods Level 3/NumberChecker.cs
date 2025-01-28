using System;

class NumberChecker
{
    static void Main(string[] args)
    {
        int number = 153; // Example number for testing
        Console.WriteLine("Number: " + number);
        Console.WriteLine("Count of Digits: " + CountDigits(number));
        int[] digits = GetDigitsArray(number);
        Console.WriteLine("Digits: " + string.Join(", ", digits));
        Console.WriteLine("Is Duck Number: " + IsDuckNumber(digits));
        Console.WriteLine("Is Armstrong Number: " + IsArmstrongNumber(number));
        FindLargestAndSecondLargest(digits);
        FindSmallestAndSecondSmallest(digits);
    }

    static int CountDigits(int num)
    {
        return num.ToString().Length;
    }

    static int[] GetDigitsArray(int num)
    {
        string numStr = num.ToString();
        int[] digits = new int[numStr.Length];
        for (int i = 0; i < numStr.Length; i++)
        {
            digits[i] = int.Parse(numStr[i].ToString());
        }
        return digits;
    }

    static bool IsDuckNumber(int[] digits)
    {
        return Array.Exists(digits, digit => digit == 0);
    }

    static bool IsArmstrongNumber(int num)
    {
        int[] digits = GetDigitsArray(num);
        int sum = 0;
        foreach (int digit in digits)
        {
            sum += (int)Math.Pow(digit, digits.Length);
        }
        return sum == num;
    }

    static void FindLargestAndSecondLargest(int[] digits)
    {
        int largest = int.MinValue, secondLargest = int.MinValue;
        foreach (int digit in digits)
        {
            if (digit > largest)
            {
                secondLargest = largest;
                largest = digit;
            }
            else if (digit > secondLargest && digit < largest)
            {
                secondLargest = digit;
            }
        }
        Console.WriteLine("Largest Digit: " + largest + ", Second Largest Digit: " + secondLargest);
    }

    static void FindSmallestAndSecondSmallest(int[] digits)
    {
        int smallest = int.MaxValue, secondSmallest = int.MaxValue;
        foreach (int digit in digits)
        {
            if (digit < smallest)
            {
                secondSmallest = smallest;
                smallest = digit;
            }
            else if (digit < secondSmallest && digit > smallest)
            {
                secondSmallest = digit;
            }
        }
        Console.WriteLine("Smallest Digit: " + smallest + ", Second Smallest Digit: " + secondSmallest);
    }
}
