using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        bool isPrime = true;

        if (number > 1)
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            Console.WriteLine(isPrime ? $"{number} is a Prime Number." : $"{number} is not a Prime Number.");
        }
        else
        {
            Console.WriteLine("Number must be greater than 1.");
        }
    }
}
