using System;

class distance
{
    static void Main()
    {
        Console.Write("Enter the distance in feet: ");
        double distanceFeet = Convert.ToDouble(Console.ReadLine());

        double distanceYards = distanceFeet / 3; // 1 yard = 3 feet
        double distanceMiles = distanceYards / 1760; // 1 mile = 1760 yards

        Console.WriteLine($"The distance is {distanceFeet} feet, which is {distanceYards:F2} yards and {distanceMiles:F2} miles.");
    }
}
