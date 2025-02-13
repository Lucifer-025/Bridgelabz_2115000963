using System;
using System.Collections.Generic;

public class QueueUsingStacks
{
    private Stack<int> stack1 = new Stack<int>();
    private Stack<int> stack2 = new Stack<int>();

    public void Enqueue(int x)
    {
        stack1.Push(x);
    }

    public int Dequeue()
    {
        if (stack2.Count == 0)
        {
            while (stack1.Count > 0)
                stack2.Push(stack1.Pop());
        }
        return stack2.Count > 0 ? stack2.Pop() : -1; // Return -1 if queue is empty
    }
}
