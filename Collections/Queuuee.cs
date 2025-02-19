using System;
using System.Collections.Generic;

class Queuuee
{
    static Queue<int> ReverseQueue(Queue<int> queue)
    {
        Stack<int> stack = new Stack<int>();
        while (queue.Count > 0)
        {
            stack.Push(queue.Dequeue());
        }
        while (stack.Count > 0)
        {
            queue.Enqueue(stack.Pop());
        }
        return queue;
    }

    static void Main()
    {
        Queue<int> queue = new Queue<int>(new int[] { 10, 20, 30 });
        var reversedQueue = ReverseQueue(queue);
        Console.WriteLine(string.Join(", ", reversedQueue)); // Output: 30, 20, 10
    }
}
