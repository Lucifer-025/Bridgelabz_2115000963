using System;

class Program
{
    static void Main()
    {
        int maths = 94, physics = 95, chemistry = 96;
        int totalMarks = maths + physics + chemistry;
        double average = totalMarks / 3.0;

        Console.WriteLine($"Sam’s average mark in PCM is {average}");
    }
}
