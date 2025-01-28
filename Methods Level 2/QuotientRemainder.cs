using System;

class QuotientRemainder
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter the divisor: ");
        int divisor = int.Parse(Console.ReadLine());

        int[] results = FindRemainderAndQuotient(number, divisor);
        Console.WriteLine($"Quotient: {results[0]}, Remainder: {results[1]}");
    }

    public static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        return new int[] { number / divisor, number % divisor };
    }
}
