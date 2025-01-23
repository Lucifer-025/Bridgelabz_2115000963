using System;

class smallest
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int number2 = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        int number3 = int.Parse(Console.ReadLine());

        Console.WriteLine($"Is the first number the smallest? {number1 < number2 && number1 < number3}");
    }
}
