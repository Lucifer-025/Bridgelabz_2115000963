using System;

class evenodd
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number > 0)
        {
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine($"{i} is even.");
                else
                    Console.WriteLine($"{i} is odd.");
            }
        }
        else
        {
            Console.WriteLine("Not a natural number.");
        }
    }
}
