using System;

class BMImulti
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of persons:");
        int numberOfPersons;
        while (!int.TryParse(Console.ReadLine(), out numberOfPersons) || numberOfPersons <= 0)
        {
            Console.WriteLine("Invalid input. Enter a positive integer:");
        }

        // Multi-dimensional array to store Weight, Height, and BMI
        double[,] personData = new double[numberOfPersons, 3];
        string[] weightStatus = new string[numberOfPersons];

        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine($"Enter details for Person {i + 1}:");

            // Input Weight
            Console.Write("Weight (in kg): ");
            while (!double.TryParse(Console.ReadLine(), out personData[i, 0]) || personData[i, 0] <= 0)
            {
                Console.WriteLine("Invalid input. Enter a positive value for weight:");
            }

            // Input Height
            Console.Write("Height (in meters): ");
            while (!double.TryParse(Console.ReadLine(), out personData[i, 1]) || personData[i, 1] <= 0)
            {
                Console.WriteLine("Invalid input. Enter a positive value for height:");
            }

            // Calculate BMI and store it
            personData[i, 2] = personData[i, 0] / (personData[i, 1] * personData[i, 1]);

            // Determine weight status
            weightStatus[i] = personData[i, 2] < 18.5 ? "Underweight" :
                              personData[i, 2] < 24.9 ? "Normal" :
                              personData[i, 2] < 29.9 ? "Overweight" : "Obese";
        }

        // Display results
        Console.WriteLine("\nBMI Results:");
        Console.WriteLine("Person\tWeight(kg)\tHeight(m)\tBMI\t\tStatus");
        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine($"{i + 1}\t{personData[i, 0]:F2}\t\t{personData[i, 1]:F2}\t\t{personData[i, 2]:F2}\t{weightStatus[i]}");
        }
    }
}
