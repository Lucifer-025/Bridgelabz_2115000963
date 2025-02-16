using System;

class Peak
{
    static void Main()
    {
        int[] arr = { 1, 3, 20, 4, 1, 0 };
        int index = FindPeakElement(arr);
        Console.Write("Peak element: ");
        Console.Write(arr[index]);
        Console.Write(" at index ");
        Console.WriteLine(index);
    }

    static int FindPeakElement(int[] arr)
    {
        int left = 0, right = arr.Length - 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;
            if (arr[mid] > arr[mid + 1])
            {
                right = mid;
            }
            else
            {
                left = mid + 1;
            }
        }
        return left;
    }
}
