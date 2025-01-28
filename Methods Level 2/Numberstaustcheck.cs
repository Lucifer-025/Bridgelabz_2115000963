using System;

class NumberStatusChecker
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int result = CheckNumberStatus(number);
        string status = result == -1 ? "Negative" : (result == 1 ? "Positive" : "Zero");
        Console.WriteLine($"The number is {status}");
    }

    static int CheckNumberStatus(int num)
    {
        if (num < 0) return -1;
        if (num > 0) return 1;
        return 0;
    }
}
