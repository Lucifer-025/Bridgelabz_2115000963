using System;

class rocketlaunch
{
    static void Main()
    {
        Console.Write("Enter a number for the countdown: ");
        int counter = int.Parse(Console.ReadLine());

        while (counter > 0)
        {
            Console.WriteLine(counter);
            counter--;
        }
        Console.WriteLine("Rocket Launch!");
    }
}
