using System;

class Target
{
    static void Main()
    {
        int[] arr = { 1, 2, 2, 2, 3, 4, 5 };
        int target = 2;

        int first = FindFirstOccurrence(arr, target);
        int last = FindLastOccurrence(arr, target);

        Console.Write("First occurrence of ");
        Console.Write(target);
        Console.Write(" is at index ");
        Console.WriteLine(first);

        Console.Write("Last occurrence of ");
        Console.Write(target);
        Console.Write(" is at index ");
        Console.WriteLine(last);
    }

    static int FindFirstOccurrence(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1, result = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (arr[mid] == target)
            {
                result = mid;
                right = mid - 1; // Continue searching in left half
            }
            else if (arr[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return result;
    }

    static int FindLastOccurrence(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1, result = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (arr[mid] == target)
            {
                result = mid;
                left = mid + 1; // Continue searching in right half
            }
            else if (arr[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return result;
    }
}
