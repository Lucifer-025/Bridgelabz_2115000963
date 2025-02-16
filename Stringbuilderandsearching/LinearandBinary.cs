using System;

class LinearandBinary
{
    static void Main()
    {
        int[] arr = { 3, 4, -1, 1 };
        int missingNumber = FindFirstMissingPositive(arr);
        Console.Write("First missing positive number: ");
        Console.WriteLine(missingNumber);

        int target = 4;
        int index = BinarySearch(arr, target);
        if (index != -1)
        {
            Console.Write("Target ");
            Console.Write(target);
            Console.Write(" found at index ");
            Console.WriteLine(index);
        }
        else
        {
            Console.WriteLine("Target not found.");
        }
    }

    // Linear Search for First Missing Positive
    static int FindFirstMissingPositive(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            while (arr[i] > 0 && arr[i] <= n && arr[arr[i] - 1] != arr[i])
            {
                int temp = arr[arr[i] - 1];
                arr[arr[i] - 1] = arr[i];
                arr[i] = temp;
            }
        }

        for (int i = 0; i < n; i++)
        {
            if (arr[i] != i + 1)
            {
                return i + 1;
            }
        }
        return n + 1;
    }

    // Binary Search for Target in Sorted Array
    static int BinarySearch(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (arr[mid] == target)
            {
                return mid;
            }
            if (arr[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return -1;
    }
}
