using System;

class FootballTeam
{
    static void Main(string[] args)
    {
        // Step 1: Generate random heights for 11 players
        int[] heights = new int[11];
        Random random = new Random();
        for (int i = 0; i < heights.Length; i++)
        {
            heights[i] = random.Next(150, 251); // Random heights between 150 and 250 cm
        }

        // Step 2: Display results
        Console.WriteLine("Player Heights: " + string.Join(", ", heights));
        Console.WriteLine("Shortest Height: " + FindShortestHeight(heights) + " cm");
        Console.WriteLine("Tallest Height: " + FindTallestHeight(heights) + " cm");
        Console.WriteLine("Mean Height: " + Math.Round(FindMeanHeight(heights), 2) + " cm");
    }

    // Method to find the sum of all elements in the array
    static int FindSum(int[] array)
    {
        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }
        return sum;
    }

    // Method to calculate the mean height
    static double FindMeanHeight(int[] heights)
    {
        int sum = FindSum(heights);
        return (double)sum / heights.Length;
    }

    // Method to find the shortest height
    static int FindShortestHeight(int[] heights)
    {
        int shortest = heights[0];
        foreach (int height in heights)
        {
            if (height < shortest)
            {
                shortest = height;
            }
        }
        return shortest;
    }

    // Method to find the tallest height
    static int FindTallestHeight(int[] heights)
    {
        int tallest = heights[0];
        foreach (int height in heights)
        {
            if (height > tallest)
            {
                tallest = height;
            }
        }
        return tallest;
    }
}
