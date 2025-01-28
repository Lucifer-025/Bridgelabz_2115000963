  using System;

class UnitConverter
{
    public static double ConvertKmToMiles(double km) => km * 0.621371;
    public static double ConvertMilesToKm(double miles) => miles * 1.60934;
    public static double ConvertMetersToFeet(double meters) => meters * 3.28084;
    public static double ConvertFeetToMeters(double feet) => feet * 0.3048;
    public static double ConvertYardsToFeet(double yards) => yards * 3;
    public static double ConvertFeetToYards(double feet) => feet * 0.333333;
    public static double ConvertMetersToInches(double meters) => meters * 39.3701;
    public static double ConvertInchesToMeters(double inches) => inches * 0.0254;
    public static double ConvertInchesToCm(double inches) => inches * 2.54;
    public static double ConvertFahrenheitToCelsius(double fahrenheit) => (fahrenheit - 32) * 5 / 9;
    public static double ConvertCelsiusToFahrenheit(double celsius) => (celsius * 9 / 5) + 32;
    public static double ConvertPoundsToKg(double pounds) => pounds * 0.453592;
    public static double ConvertKgToPounds(double kg) => kg * 2.20462;
    public static double ConvertGallonsToLiters(double gallons) => gallons * 3.78541;
    public static double ConvertLitersToGallons(double liters) => liters * 0.264172;
}

