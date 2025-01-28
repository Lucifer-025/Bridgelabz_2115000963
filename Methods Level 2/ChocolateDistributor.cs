using System;

class ChocolateDistributor
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of chocolates: ");
        int chocolates = int.Parse(Console.ReadLine());

        Console.Write("Enter number of children: ");
        int children = int.Parse(Console.ReadLine());

        int[] results = FindRemainderAndQuotient(chocolates, children);
        Console.WriteLine($"Each child gets {results[0]} chocolates, Remaining chocolates: {results[1]}");
    }

    public static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        return new int[] { number / divisor, number % divisor };
    }
}
