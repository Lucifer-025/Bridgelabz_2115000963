using System;
using System.Collections.Generic;

class Shopping
{
    static void Main()
    {
        SortedDictionary<string, double> cart = new SortedDictionary<string, double>();
        cart["Laptop"] = 1000.00;
        cart["Mouse"] = 25.50;
        cart["Keyboard"] = 45.00;

        Console.WriteLine("Shopping Cart Items (Sorted by Name):");
        foreach (var item in cart)
            Console.WriteLine("item.Key + item.Value);
    }
}
