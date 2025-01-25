using System;

class MultiplicationTableRange
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int[] table = new int[4];

        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }
    }
}
