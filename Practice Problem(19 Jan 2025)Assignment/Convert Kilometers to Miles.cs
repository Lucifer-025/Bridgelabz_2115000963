using System;

class Program10
{
    static void Main()
    {
        Console.Write("Enter the distance in kilometers: ");
        double kilometers = double.Parse(Console.ReadLine());

        double miles = kilometers * 0.621371;
        Console.WriteLine("The distance in miles is: " + miles);
    }
}
