using System;

class Quadraticequation
{
    static void Main(string[] args)
    {
        Console.Write("Enter coefficient a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter coefficient b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter coefficient c: ");
        double c = double.Parse(Console.ReadLine());

        double[] roots = FindRoots(a, b, c);

        if (roots.Length == 0)
        {
            Console.WriteLine("No real roots exist.");
        }
        else if (roots.Length == 1)
        {
            Console.WriteLine($"One real root: {roots[0]:F2}");
        }
        else
        {
            Console.WriteLine($"Two real roots: {roots[0]:F2}, {roots[1]:F2}");
        }
    }

    static double[] FindRoots(double a, double b, double c)
    {
        double delta = Math.Pow(b, 2) - 4 * a * c;

        if (delta < 0) return new double[0];
        if (delta == 0) return new double[] { -b / (2 * a) };

        double sqrtDelta = Math.Sqrt(delta);
        return new double[] { (-b + sqrtDelta) / (2 * a), (-b - sqrtDelta) / (2 * a) };
    }
}
