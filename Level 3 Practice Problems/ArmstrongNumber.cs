using System;

class ArmstrongNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int sum = 0;
        int originalNumber = number;

        while (originalNumber != 0)
        {
            int digit = originalNumber % 10; // Get the last digit
            sum += digit * digit * digit; // Add the cube of the digit to sum
            originalNumber /= 10; // Remove the last digit
        }

        if (number == sum)
            Console.WriteLine($"{number} is an Armstrong number.");
        else
            Console.WriteLine($"{number} is not an Armstrong number.");
    }
}