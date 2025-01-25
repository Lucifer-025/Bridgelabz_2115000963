using System;

class youngestandtallest
{
    static void Main(string[] args)
    {
        string[] names = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        double[] heights = new double[3];

        // Input ages and heights
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Enter the age of {names[i]}:");
            while (!int.TryParse(Console.ReadLine(), out ages[i]) || ages[i] <= 0)
            {
                Console.WriteLine("Invalid input. Enter a positive integer for age:");
            }

            Console.WriteLine($"Enter the height (in cm) of {names[i]}:");
            while (!double.TryParse(Console.ReadLine(), out heights[i]) || heights[i] <= 0)
            {
                Console.WriteLine("Invalid input. Enter a positive number for height:");
            }
        }

        // Find youngest and tallest
        int youngestIndex = 0;
        int tallestIndex = 0;

        for (int i = 1; i < 3; i++)
        {
            if (ages[i] < ages[youngestIndex])
            {
                youngestIndex = i;
            }
            if (heights[i] > heights[tallestIndex])
            {
                tallestIndex = i;
            }
        }

        // Display results
        Console.WriteLine($"\nThe youngest friend is {names[youngestIndex]} with age {ages[youngestIndex]} years.");
        Console.WriteLine($"The tallest friend is {names[tallestIndex]} with height {heights[tallestIndex]} cm.");
    }
}
