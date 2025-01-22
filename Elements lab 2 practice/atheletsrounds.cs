using System;

class AthleteRounds
{
    static void Main()
    {
        Console.Write("Enter side1 of the park in meters: ");
        double side1 = double.Parse(Console.ReadLine());
        Console.Write("Enter side2 of the park in meters: ");
        double side2 = double.Parse(Console.ReadLine());
        Console.Write("Enter side3 of the park in meters: ");
        double side3 = double.Parse(Console.ReadLine());

        double perimeter = side1 + side2 + side3;
        double rounds = 5000 / perimeter;

        Console.WriteLine($"The total number of rounds the athlete will run is {Math.Ceiling(rounds)} to complete 5 km");
    }
}
