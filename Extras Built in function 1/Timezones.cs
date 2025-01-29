using System;

class Timezones
{
    static void Main()
    {
        DateTimeOffset currentTime = DateTimeOffset.UtcNow;

        Console.WriteLine("Current Time in GMT: " + currentTime);

        TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        DateTimeOffset istTime = TimeZoneInfo.ConvertTime(currentTime, istZone);
        Console.WriteLine("Current Time in IST: " + istTime);

        TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
        DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(currentTime, pstZone);
        Console.WriteLine("Current Time in PST: " + pstTime);
    }
}
