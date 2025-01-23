using System;

class factorial
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number >= 0)
        {
            int factorial = 1, i = 1;

            while (i <= number)
            {
                factorial *= i;
                i++;
            }

            Console.WriteLine($"The factorial of {number} is {factorial}");
        }
        else
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");
        }
    }
}
