using System;
using System.Collections.Generic;

class Duplicates
{
    static List<int> RemoveDuplicates(List<int> list)
    {
        HashSet<int> seen = new HashSet<int>();
        List<int> result = new List<int>();
        foreach (var num in list)
        {
            if (!seen.Contains(num))
            {
                seen.Add(num);
                result.Add(num);
            }
        }
        return result;
    }

    static void Main()
    {
        List<int> numbers = new List<int> { 3, 1, 2, 2, 3, 4 };
        var result = RemoveDuplicates(numbers);
        Console.WriteLine(string.Join(", ", result));
    }
}
