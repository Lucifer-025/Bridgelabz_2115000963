using System;

class BMICalculator
{
    static void Main(string[] args)
    {
        double[,] data = new double[10, 3]; // [Weight, Height, BMI]
        string[] status = new string[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter weight (kg) of person {i + 1}: ");
            data[i, 0] = double.Parse(Console.ReadLine());

            Console.Write($"Enter height (cm) of person {i + 1}: ");
            data[i, 1] = double.Parse(Console.ReadLine()) / 100; // Convert to meters

            data[i, 2] = CalculateBMI(data[i, 0], data[i, 1]);
            status[i] = GetBMIStatus(data[i, 2]);

            Console.WriteLine($"BMI: {data[i, 2]:F2}, Status: {status[i]}");
        }
    }

    static double CalculateBMI(double weight, double height) => weight / (height * height);

    static string GetBMIStatus(double bmi)
    {
        if (bmi < 18.5) return "Underweight";
        if (bmi >= 18.5 && bmi <= 24.9) return "Normal weight";
        if (bmi >= 25 && bmi <= 29.9) return "Overweight";
        return "Obesity";
    }
}
