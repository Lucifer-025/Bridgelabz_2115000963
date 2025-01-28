using System;

class youngestandtallest
{
    static void Main(string[] args)
    {
        string[] friends = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        int[] heights = new int[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter age of {friends[i]}: ");
            ages[i] = int.Parse(Console.ReadLine());
            Console.Write($"Enter height of {friends[i]} (in cm): ");
            heights[i] = int.Parse(Console.ReadLine());
        }

        int youngest = Array.IndexOf(ages, Math.Min(ages[0], Math.Min(ages[1], ages[2])));
        int tallest = Array.IndexOf(heights, Math.Max(heights[0], Math.Max(heights[1], heights[2])));

        Console.WriteLine($"Youngest: {friends[youngest]}");
        Console.WriteLine($"Tallest: {friends[tallest]}");
    }
}
