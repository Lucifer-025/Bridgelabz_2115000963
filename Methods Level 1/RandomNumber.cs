using System;

class RandomNumber
{
    static void Main(string[] args)
    {
        int[] randomNumbers = Generate4DigitRandomArray(5);
        Console.WriteLine("Generated Numbers: " + string.Join(", ", randomNumbers));

        double[] results = FindAverageMinMax(randomNumbers);
        Console.WriteLine($"Average: {results[0]:F2}");
        Console.WriteLine($"Minimum: {results[1]}");
        Console.WriteLine($"Maximum: {results[2]}");
    }

    static int[] Generate4DigitRandomArray(int size)
    {
        Random random = new Random();
        int[] numbers = new int[size];

        for (int i = 0; i < size; i++)
        {
            numbers[i] = random.Next(1000, 10000); // 4-digit numbers
        }
        return numbers;
    }

    static double[] FindAverageMinMax(int[] numbers)
    {
        int min = int.MaxValue, max = int.MinValue, sum = 0;

        foreach (int num in numbers)
        {
            sum += num;
            if (num < min) min = num;
            if (num > max) max = num;
        }

        return new double[] { (double)sum / numbers.Length, min, max };
    }
}
