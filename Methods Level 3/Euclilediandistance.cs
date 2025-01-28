using System;

class Euclilediandistance
{
    // Method to calculate Euclidean distance
    public static double CalculateEuclideanDistance(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }

    // Method to calculate the equation of a line
    public static double[] CalculateLineEquation(double x1, double y1, double x2, double y2)
    {
        double[] result = new double[2];

        // Calculate the slope (m)
        double m = (y2 - y1) / (x2 - x1);

        // Calculate the y-intercept (b)
        double b = y1 - m * x1;

        result[0] = m;  // slope
        result[1] = b;  // y-intercept

        return result;
    }

    static void Main(string[] args)
    {
        // Input two points
        Console.Write("Enter x1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter y1: ");
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter x2: ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter y2: ");
        double y2 = Convert.ToDouble(Console.ReadLine());

        // Calculate and display Euclidean distance
        double distance = CalculateEuclideanDistance(x1, y1, x2, y2);
        Console.WriteLine($"Euclidean distance between the points: {distance}");

        // Calculate and display line equation (slope and y-intercept)
        double[] lineEquation = CalculateLineEquation(x1, y1, x2, y2);
        Console.WriteLine($"Equation of the line: y = {lineEquation[0]}x + {lineEquation[1]}");
    }
}
