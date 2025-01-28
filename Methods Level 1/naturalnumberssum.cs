using System;

class naturalnumberssum
{
    static void Main(string[] args)
    {
        Console.Write("Enter a natural number: ");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("Please enter a natural number (n > 0).");
            return;
        }

        int recursiveSum = RecursiveSum(n);
        int formulaSum = FormulaSum(n);

        Console.WriteLine($"Sum using recursion: {recursiveSum}");
        Console.WriteLine($"Sum using formula: {formulaSum}");

        Console.WriteLine(recursiveSum == formulaSum ? "Both results match!" : "Results do not match.");
    }

    static int RecursiveSum(int n)
    {
        if (n == 1) return 1;
        return n + RecursiveSum(n - 1);
    }

    static int FormulaSum(int n)
    {
        return n * (n + 1) / 2;
    }
}
