using System;

class TripDetails
{
    static void Main()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        Console.Write("Enter starting city: ");
        string fromCity = Console.ReadLine();
        Console.Write("Enter via city: ");
        string viaCity = Console.ReadLine();
        Console.Write("Enter destination city: ");
        string toCity = Console.ReadLine();
        Console.Write("Enter distance from start to via city in miles: ");
        double fromToVia = double.Parse(Console.ReadLine());
        Console.Write("Enter distance from via to final city in miles: ");
        double viaToFinalCity = double.Parse(Console.ReadLine());
        Console.Write("Enter time taken for the journey in hours: ");
        double timeTaken = double.Parse(Console.ReadLine());

        double totalDistance = fromToVia + viaToFinalCity;
        double averageSpeed = totalDistance / timeTaken;

        Console.WriteLine($"The results of the trip are: Total Distance = {totalDistance} miles, Average Speed = {averageSpeed} mph");
    }
}
