using System;

class SpringSeason
{
    static void Main(string[] args)
    {
        Console.Write("Enter month (1-12): ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter day (1-31): ");
        int day = int.Parse(Console.ReadLine());

        if (IsSpringSeason(month, day))
            Console.WriteLine("It's a Spring Season");
        else
            Console.WriteLine("Not a Spring Season");
    }

    static bool IsSpringSeason(int month, int day)
    {
        return (month == 3 && day >= 20) || (month > 3 && month < 6) || (month == 6 && day <= 20);
    }
}
