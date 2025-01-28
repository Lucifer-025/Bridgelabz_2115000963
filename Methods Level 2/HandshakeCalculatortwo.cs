using System;

class HandshakeCalculator
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of students: ");
        int students = int.Parse(Console.ReadLine());

        int handshakes = CalculateHandshakes(students);
        Console.WriteLine($"The maximum number of handshakes is {handshakes}");
    }

    static int CalculateHandshakes(int n)
    {
        return n * (n - 1) / 2;
    }
}
