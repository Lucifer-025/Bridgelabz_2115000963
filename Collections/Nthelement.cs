using System;
using System.Collections.Generic;

class Nthelement
{
    static string FindNthFromEnd(LinkedList<string> list, int n)
    {
        LinkedListNode<string> fast = list.First;
        LinkedListNode<string> slow = list.First;

        for (int i = 0; i < n; i++)
        {
            if (fast == null) return "N is out of bounds";
            fast = fast.Next;
        }

        while (fast != null)
        {
            slow = slow.Next;
            fast = fast.Next;
        }

        return slow.Value;
    }

    static void Main()
    {
        LinkedList<string> linkedList = new LinkedList<string>(new string[] { "A", "B", "C", "D", "E" });
        Console.WriteLine(FindNthFromEnd(linkedList, 2)); // Output: D
    }
}
