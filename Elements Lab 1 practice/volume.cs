using System;

class volume
{
    static void Main()
    {
        double radiusKm = 6378;
        double radiusMiles = radiusKm / 1.609; // Conversion factor: 1 mile = 1.609 km
        double volumeKm3 = (4.0 / 3.0) * Math.PI * Math.Pow(radiusKm, 3);
        double volumeMiles3 = (4.0 / 3.0) * Math.PI * Math.Pow(radiusMiles, 3);

        Console.WriteLine($"The volume of earth in cubic kilometers is {volumeKm3:F2} and cubic miles is {volumeMiles3:F2}");
    }
}
