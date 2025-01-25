using System;

class maxdigit
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        long number;
        while (!long.TryParse(Console.ReadLine(), out number) || number < 0)
        {
            Console.WriteLine("Invalid input. Enter a positive number:");
        }

        // Initial array size and index
        int maxDigit = 10;
        int[] digits = new int[maxDigit];
        int index = 0;

        // Extract digits and dynamically resize the array if needed
        while (number != 0)
        {
            if (index == maxDigit)
            {
                // Increase maxDigit by 10 and resize the array
                maxDigit += 10;
                int[] temp = new int[maxDigit];
                for (int i = 0; i < digits.Length; i++)
                {
                    temp[i] = digits[i];
                }
                digits = temp;
            }

            digits[index] = (int)(number % 10);
            number /= 10;
            index++;
        }

        // Find the largest and second-largest digits
        int largest = -1, secondLargest = -1;

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

        // Display the results
        Console.WriteLine("\nDigits in the number:");
        for (int i = 0; i < index; i++)
        {
            Console.Write(digits[i] + " ");
        }
        Console.WriteLine($"\nLargest digit: {largest}");
        Console.WriteLine($"Second largest digit: {secondLargest}");
    }
}
