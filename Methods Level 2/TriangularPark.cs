using System;

class TriangularPark
{
    static void Main(string[] args)
    {
        Console.Write("Enter side 1 of the park (in meters): ");
        double side1 = double.Parse(Console.ReadLine());

        Console.Write("Enter side 2 of the park (in meters): ");
        double side2 = double.Parse(Console.ReadLine());

        Console.Write("Enter side 3 of the park (in meters): ");
        double side3 = double.Parse(Console.ReadLine());

        double rounds = CalculateRounds(side1, side2, side3);
        Console.WriteLine($"The athlete needs to complete {Math.Ceiling(rounds)} rounds to finish 5 km.");
    }

    static double CalculateRounds(double side1, double side2, double side3)
    {
        double perimeter = side1 + side2 + side3;
        return 5000 / perimeter;
    }
}

