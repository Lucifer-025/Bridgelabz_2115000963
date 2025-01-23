using System;

class HarshadNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int sum = 0;
        int originalNumber = number;

        while (originalNumber != 0)
        {
            sum += originalNumber % 10; // Add each digit to sum
            originalNumber /= 10; // Remove the last digit
        }

        if (number % sum == 0)
            Console.WriteLine($"{number} is a Harshad number.");
        else
            Console.WriteLine($"{number} is not a Harshad number.");
    }
}