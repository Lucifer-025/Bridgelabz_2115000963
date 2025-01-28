using System;

class WindChillCalculator
{
    static void Main(string[] args)
    {
        Console.Write("Enter temperature (in Fahrenheit): ");
        double temperature = double.Parse(Console.ReadLine());

        Console.Write("Enter wind speed (in mph): ");
        double windSpeed = double.Parse(Console.ReadLine());

        double windChill = CalculateWindChill(temperature, windSpeed);
        Console.WriteLine($"The wind chill temperature is {windChill:F2}°F");
    }

    public static double CalculateWindChill(double temperature, double windSpeed)
    {
        return 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);
    }
}
