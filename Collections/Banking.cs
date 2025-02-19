using System;
using System.Collections.Generic;

class Banking
{
    static void Main()
    {
        Dictionary<int, double> accounts = new Dictionary<int, double>
        {
            { 101, 5000.00 },
            { 102, 3000.50 },
            { 103, 7500.75 }
        };

        Queue<int> withdrawalRequests = new Queue<int>();
        withdrawalRequests.Enqueue(101);
        withdrawalRequests.Enqueue(103);

        while (withdrawalRequests.Count > 0)
        {
            int accId = withdrawalRequests.Dequeue();
            Console.WriteLine("Processing withdrawal for account" +accId);
        }
    }
}
