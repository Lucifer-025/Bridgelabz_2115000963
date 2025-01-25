using System;

class Copy2DTo1D
{
    static void Main()
    {
        Console.Write("Enter rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter columns: ");
        int columns = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, columns];
        int[] array = new int[rows * columns];

        Console.WriteLine("Enter matrix elements:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int index = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[index++] = matrix[i, j];
            }
        }

        Console.WriteLine("1D Array:");
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
    }
}
