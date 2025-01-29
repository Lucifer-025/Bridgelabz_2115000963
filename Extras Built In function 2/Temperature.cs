using System;

class Temperature
{
    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    static void Main()
    {
        Console.Write("Enter temperature: ");
        double temp = double.Parse(Console.ReadLine());

        Console.Write("Convert to (C/F)? ");
        char choice = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        if (choice == 'C')
            Console.WriteLine($"Temperature in Celsius: {FahrenheitToCelsius(temp)}");
        else if (choice == 'F')
            Console.WriteLine($"Temperature in Fahrenheit: {CelsiusToFahrenheit(temp)}");
        else
            Console.WriteLine("Invalid choice.");
    }
}
