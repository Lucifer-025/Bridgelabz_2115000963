using System;

class MergeArrays
{
    static void Main(string[] args)
    {
        int[] array1 = { 1, 3, 5 };
        int[] array2 = { 2, 4, 6 };
        Console.WriteLine("Array 1: " + string.Join(", ", array1));
        Console.WriteLine("Array 2: " + string.Join(", ", array2));

        int[] mergedArray = Merge(array1, array2);
        Console.WriteLine("Merged Array: " + string.Join(", ", mergedArray));
    }

    static int[] Merge(int[] array1, int[] array2)
    {
        int[] merged = new int[array1.Length + array2.Length];
        array1.CopyTo(merged, 0);
        array2.CopyTo(merged, array1.Length);
        return merged;
    }
}
