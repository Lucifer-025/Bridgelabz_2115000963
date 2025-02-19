using System;
using System.Collections.Generic;

class Binarynum
{
    static List<string> GenerateBinaryNumbers(int n)
    {
        List<string> result = new List<string>();
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("1");

        for (int i = 0; i < n; i++)
        {
            string num = queue.Dequeue();
            result.Add(num);
            queue.Enqueue(num + "0");
            queue.Enqueue(num + "1");
        }

        return result;
    }

    static void Main()
    {
        var result = GenerateBinaryNumbers(5);
        Console.WriteLine(string.Join(", ", result)); // Output: 1, 10, 11, 100, 101
    }
}
