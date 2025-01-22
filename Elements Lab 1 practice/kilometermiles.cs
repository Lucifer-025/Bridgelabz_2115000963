using System;

class kilometermiles
{
    static void Main()
    {
        Console.Write("Enter distance in kilometers: ");
        double km = Convert.ToDouble(Console.ReadLine());
        
        double miles = km / 1.6; // 1 mile = 1.6 km
        
        Console.WriteLine($"The total miles is {miles} mile for the given {km} km");
    }
}
