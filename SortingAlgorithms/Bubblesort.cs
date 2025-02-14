using System;
class Bubblesort
{
    static void Main()
    {
        int[] marks = { 56, 54, 88, 66, 67, 99, 100, 54 };

        int n = marks.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {

                if (marks[j] > marks[j + 1])
                {
                    int temp = marks[j];
                    marks[j] = marks[j + 1];
                    marks[j + 1] = temp;
                }
            }
        }
        Console.WriteLine("Sorted Marks:");
        foreach (var mark in marks)
        {
            Console.Write(mark + " ");
        }
    }
}