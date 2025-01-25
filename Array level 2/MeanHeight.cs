using System;

class MeanHeight
{
    static void Main()
    {
        double[] heights = new double[11];
        double sum = 0;

        Console.WriteLine("Enter the heights of 11 players:");
        for (int i = 0; i < heights.Length; i++)
        {
            Console.Write($"Player {i + 1}: ");
            heights[i] = double.Parse(Console.ReadLine());
            sum += heights[i];
        }

        double mean = sum / heights.Length;
        Console.WriteLine($"Mean height of the team: {mean}");
    }
}
