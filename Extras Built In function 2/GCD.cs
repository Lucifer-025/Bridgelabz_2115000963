using System;

class GCD
{
    static int GCD(int a, int b)
    {
        return b == 0 ? a : GCD(b, a % b);
    }

    static int LCM(int a, int b)
    {
        return (a * b) / GCD(a, b);
    }

    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"GCD: {GCD(num1, num2)}");
        Console.WriteLine($"LCM: {LCM(num1, num2)}");
    }
}
