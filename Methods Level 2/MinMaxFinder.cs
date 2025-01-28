using System;

class MinMaxFinder
{
    static void Main(string[] args)
    {
        Console.Write("Enter number 1: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter number 2: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter number 3: ");
        int num3 = int.Parse(Console.ReadLine());

        int[] results = FindSmallestAndLargest(num1, num2, num3);
        Console.WriteLine($"Smallest: {results[0]}, Largest: {results[1]}");
    }

    public static int[] FindSmallestAndLargest(int number1, int number2, int number3)
    {
        int smallest = Math.Min(number1, Math.Min(number2, number3));
        int largest = Math.Max(number1, Math.Max(number2, number3));
        return new int[] { smallest, largest };
    }
}
