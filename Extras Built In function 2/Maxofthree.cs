using System;

class Maxofthree
{
    static int FindMax(int a, int b, int c)
    {
        return Math.Max(a, Math.Max(b, c));
    }

    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int num3 = int.Parse(Console.ReadLine());

        Console.WriteLine($"Maximum: {FindMax(num1, num2, num3)}");
    }
}
