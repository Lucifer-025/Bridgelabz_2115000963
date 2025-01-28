using System;

class Calendar
{
    // Method to get the name of the month
    public static string GetMonthName(int month)
    {
        string[] months = { "January", "February", "March", "April", "May", "June",
                            "July", "August", "September", "October", "November", "December" };
        return months[month - 1];
    }

    // Method to check if a year is a leap year
    public static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    // Method to get the number of days in a month
    public static int GetNumberOfDays(int month, int year)
    {
        int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        if (month == 2 && IsLeapYear(year))
        {
            return 29; // February has 29 days in a leap year
        }

        return daysInMonth[month - 1];
    }

    // Method to get the first day of the month (using Gregorian calendar algorithm)
    public static int GetFirstDayOfMonth(int month, int year)
    {
        int y0 = year - (14 - month) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = month + 12 * ((14 - month) / 12) - 2;
        int d0 = (1 + x + 31 * m0 / 12) % 7;

        return d0; // The result is a number representing the day of the week (0=Sunday, 1=Monday, etc.)
    }

    // Method to display the calendar
    public static void DisplayCalendar(int month, int year)
    {
        string monthName = GetMonthName(month);
        int numberOfDays = GetNumberOfDays(month, year);
        int firstDay = GetFirstDayOfMonth(month, year);

        // Display the header with the month and year
        Console.WriteLine($"{monthName} {year}");
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        // Add indentation for the first day of the month
        for (int i = 0; i < firstDay; i++)
        {
            Console.Write("    "); // Print 4 spaces for each day before the first day
        }

        // Display the days of the month
        for (int day = 1; day <= numberOfDays; day++)
        {
            Console.Write($"{day,3} "); // Print each day right-justified in a field of width 3

            // If it's the last day of the week, go to the next line
            if ((firstDay + day) % 7 == 0)
            {
                Console.WriteLine();
            }
        }

        Console.WriteLine(); // Ensure there's a newline at the end of the calendar
    }

    static void Main(string[] args)
    {
        // Input month and year
        Console.Write("Enter the month (1-12): ");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        // Display the calendar for the given month and year
        DisplayCalendar(month, year);
    }
}
