using System;

class BMI
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of persons:");
        int numberOfPersons;
        while (!int.TryParse(Console.ReadLine(), out numberOfPersons) || numberOfPersons <= 0)
        {
            Console.WriteLine("Invalid input. Enter a positive integer:");
        }

        double[] weights = new double[numberOfPersons];
        double[] heights = new double[numberOfPersons];
        double[] bmis = new double[numberOfPersons];
        string[] statuses = new string[numberOfPersons];

        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine($"Enter the weight (in kg) of person {i + 1}:");
            while (!double.TryParse(Console.ReadLine(), out weights[i]) || weights[i] <= 0)
            {
                Console.WriteLine("Invalid input. Enter a positive number:");
            }

            Console.WriteLine($"Enter the height (in meters) of person {i + 1}:");
            while (!double.TryParse(Console.ReadLine(), out heights[i]) || heights[i] <= 0)
            {
                Console.WriteLine("Invalid input. Enter a positive number:");
            }

            bmis[i] = weights[i] / (heights[i] * heights[i]);

            statuses[i] = bmis[i] < 18.5 ? "Underweight" :
                          bmis[i] < 24.9 ? "Normal" :
                          bmis[i] < 29.9 ? "Overweight" : "Obese";
        }

        Console.WriteLine("\nBMI Results:");
        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine($"Person {i + 1}: Height = {heights[i]}m, Weight = {weights[i]}kg, BMI = {bmis[i]:F2}, Status = {statuses[i]}");
        }
    }
}
