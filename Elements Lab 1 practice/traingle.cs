using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the base of the triangle in cm: ");
        double baseCm = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the triangle in cm: ");
        double heightCm = Convert.ToDouble(Console.ReadLine());

        double areaCm2 = 0.5 * baseCm * heightCm;
        double areaInches2 = areaCm2 / 6.4516; // 1 square inch = 6.4516 square cm

        Console.WriteLine($"The area of the triangle is {areaCm2:F2} square centimeters and {areaInches2:F2} square inches.");
    }
}
