using System;

class Studentmark
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of students:");
        int numberOfStudents;
        while (!int.TryParse(Console.ReadLine(), out numberOfStudents) || numberOfStudents <= 0)
        {
            Console.WriteLine("Invalid input. Enter a positive integer:");
        }

        int[,] marks = new int[numberOfStudents, 3];
        double[] percentages = new double[numberOfStudents];
        char[] grades = new char[numberOfStudents];

        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine($"Enter marks for Student {i + 1}:");

            for (int j = 0; j < 3; j++)
            {
                string subject = j == 0 ? "Physics" : j == 1 ? "Chemistry" : "Maths";
                Console.WriteLine($"{subject}:");

                while (!int.TryParse(Console.ReadLine(), out marks[i, j]) || marks[i, j] < 0 || marks[i, j] > 100)
                {
                    Console.WriteLine("Invalid input. Enter a number between 0 and 100:");
                }
            }

            int totalMarks = marks[i, 0] + marks[i, 1] + marks[i, 2];
            percentages[i] = (double)totalMarks / 3;

            grades[i] = percentages[i] >= 90 ? 'A' :
                        percentages[i] >= 75 ? 'B' :
                        percentages[i] >= 50 ? 'C' : 'D';
        }

        Console.WriteLine("\nStudent Results:");
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine($"Student {i + 1}: Physics = {marks[i, 0]}, Chemistry = {marks[i, 1]}, Maths = {marks[i, 2]}, Percentage = {percentages[i]:F2}%, Grade = {grades[i]}");
        }
    }
}
