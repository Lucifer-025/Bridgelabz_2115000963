using System;

class FriendsComparison
{
    static void Main()
    {
        Console.WriteLine("Enter the age and height of Amar:");
        int ageAmar = int.Parse(Console.ReadLine());
        double heightAmar = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the age and height of Akbar:");
        int ageAkbar = int.Parse(Console.ReadLine());
        double heightAkbar = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the age and height of Anthony:");
        int ageAnthony = int.Parse(Console.ReadLine());
        double heightAnthony = double.Parse(Console.ReadLine());

        int youngest = Math.Min(ageAmar, Math.Min(ageAkbar, ageAnthony));
        double tallest = Math.Max(heightAmar, Math.Max(heightAkbar, heightAnthony));

        Console.WriteLine($"Youngest Age: {youngest}");
        Console.WriteLine($"Tallest Height: {tallest}");
    }
}
