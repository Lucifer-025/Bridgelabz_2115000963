using System;

class leapyearchecker
{
    static void Main(string[] args)
    {
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());

        if (year < 1582)
        {
            Console.WriteLine("Year must be >= 1582 (Gregorian calendar).");
            return;
        }

        Console.WriteLine(IsLeapYear(year) ? "It's a Leap Year." : "It's not a Leap Year.");
    }

    static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}
