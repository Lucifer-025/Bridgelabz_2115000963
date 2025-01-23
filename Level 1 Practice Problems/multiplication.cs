using System;

class multiplication
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }
    }
}
