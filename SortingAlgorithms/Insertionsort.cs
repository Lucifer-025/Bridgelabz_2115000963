using System;

class InsertionSort
{
    static void Sort(int[] id)
    {
        int n = id.Length;
        for (int i = 1; i < n; i++)
        {
            int key = id[i];
            int j = i - 1;
            while (j >= 0 && ids[j] > key)
            {
                id[j + 1] = id[j];
                j--;
            }
            ids[j + 1] = key;
        }
    }

    static void Main()
    {
        int[] id = { 104, 101, 108, 102, 107 };
        Sort(ids);
        Console.WriteLine("Sorted Employee IDs: " + string.Join(", ", ids));
    }
}
