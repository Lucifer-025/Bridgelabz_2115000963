using System;

class TrigonometricCalculator
{
    static void Main(string[] args)
    {
        Console.Write("Enter an angle (in degrees): ");
        double angle = double.Parse(Console.ReadLine());

        double[] results = CalculateTrigonometricFunctions(angle);
        Console.WriteLine($"Sin: {results[0]:F2}, Cos: {results[1]:F2}, Tan: {results[2]:F2}");
    }

    public static double[] CalculateTrigonometricFunctions(double angle)
    {
        double radians = Math.PI * angle / 180;
        return new double[] { Math.Sin(radians), Math.Cos(radians), Math.Tan(radians) };
    }
}
