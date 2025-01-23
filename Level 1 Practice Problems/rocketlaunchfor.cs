using System;

class rocketlaunchfor.cs

{
    static void Main()
    {
        Console.Write("Enter a number for the countdown: ");
        int counter = int.Parse(Console.ReadLine());

        for (int i = counter; i > 0; i--)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Rocket Launch!");
    }
}
