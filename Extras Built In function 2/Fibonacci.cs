using System;

class Fibonacci
{
    static void GenerateFibonacci(int terms)
    {
        int a = 0, b = 1, next;
        for (int i = 0; i < terms; i++)
        {
            Console.Write(a + " ");
            next = a + b;
            a = b;
            b = next;
        }
    }

    static void Main()
    {
        Console.Write("Enter number of terms: ");
        int terms = int.Parse(Console.ReadLine());

        GenerateFibonacci(terms);
    }
}
