using System;

class StudentScorecard
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of students: ");
        int numStudents = int.Parse(Console.ReadLine());

        int[,] scores = GenerateScores(numStudents);
        double[,] results = CalculateResults(scores);
        DisplayScorecard(scores, results);
    }

    static int[,] GenerateScores(int count)
    {
        Random random = new Random();
        int[,] scores = new int[count, 3];
        for (int i = 0; i < count; i++)
        {
            scores[i, 0] = random.Next(10, 100); // Physics
            scores[i, 1] = random.Next(10, 100); // Chemistry
            scores[i, 2] = random.Next(10, 100); // Math
        }
        return scores;
    }

    static double[,] CalculateResults(int[,] scores)
    {
        double[,] results = new double[scores.GetLength(0), 3];
        for (int i = 0; i < scores.GetLength(0); i++)
        {
            int total = scores[i, 0] + scores[i, 1] + scores[i, 2];
            double average = total / 3.0;
            double percentage = total / 3.0;
            results[i, 0] = total;
            results[i, 1] = Math.Round(average, 2);
            results[i, 2] = Math.Round(percentage, 2);
        }
        return results;
    }

    static void DisplayScorecard(int[,] scores, double[,] results)
    {
        Console.WriteLine("Student\tPhysics\tChemistry\tMath\tTotal\tAverage\tPercentage");
        for (int i = 0; i < scores.GetLength(0); i++)
        {
            Console.Write($"{i + 1}\t{scores[i, 0]}\t{scores[i, 1]}\t\t{scores[i, 2]}\t{results[i, 0]}\t{results[i, 1]}\t{results[i, 2]}%");
            Console.WriteLine();
        }
    }
}
