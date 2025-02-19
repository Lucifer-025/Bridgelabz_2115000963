using System;
using System.Collections.Generic;

class Rotate
{
    static List<int> RotateList(List<int> list, int k)
    {
        int n = list.Count;
        k %= n;
        List<int> rotated = new List<int>(list.Skip(k).Concat(list.Take(k)));
        return rotated;
    }

    static void Main()
    {
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
        var result = RotateList(numbers, 2);
        Console.WriteLine(string.Join(", ", result));
    }
}
