using System;

class Rotation
{
    static void Main()
    {
        int[] arr = { 4, 5, 6, 7, 0, 1, 2 };
        int index = FindRotationPoint(arr);
        Console.Write("Rotation point index: ");
        Console.WriteLine(index);
    }

    static int FindRotationPoint(int[] arr)
    {
        int left = 0, right = arr.Length - 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;
            if (arr[mid] > arr[right])
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }
        return left;
    }
}
