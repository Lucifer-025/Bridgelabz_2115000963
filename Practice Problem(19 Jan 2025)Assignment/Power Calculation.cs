using System;

class Program8
{
    static void Main()
    {
        Console.Write("Enter the base: ");
        double baseNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter the exponent: ");
        double exponent = double.Parse(Console.ReadLine());

        double result = Math.Pow(baseNumber, exponent);
        Console.WriteLine("The result is: " + result);
    }
}
