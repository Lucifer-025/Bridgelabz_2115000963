using System;

class Negative
{
    static void Main()
    {
        int[] arr = { 3, 7, -2, 8, -5, 4 };
        int index = FindFirstNegative(arr);

        if (index != -1)
        {
            Console.Write("First negative number: ");
            Console.Write(arr[index]);
            Console.Write(" at index ");
            Console.WriteLine(index);
        }
        else
        {
            Console.WriteLine("No negative number found.");
        }
    }

    static int FindFirstNegative(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
            {
                return i;
            }
        }
        return -1;
    }
}
