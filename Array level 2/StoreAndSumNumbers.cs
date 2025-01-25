using System;

class StoreAndSumNumbers
{
    static void Main()
    {
        double[] numbers = new double[10];
        double total = 0.0;
        int index = 0;

        Console.WriteLine("Enter numbers (Enter 0 or a negative number to stop):");
        while (index < 10)
        {
            Console.Write($"Number {index + 1}: ");
            double num = double.Parse(Console.ReadLine());
            if (num <= 0)
                break;

            numbers[index] = num;
            index++;
        }

        Console.WriteLine("Numbers entered:");
        for (int i = 0; i < index; i++)
        {
            total += numbers[i];
            Console.WriteLine(numbers[i]);
        }

        Console.WriteLine($"Sum of all numbers: {total}");
    }
}
