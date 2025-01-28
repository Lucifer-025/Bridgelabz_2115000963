using System;

public class NumberCheckerthree
{
    public static bool IsPrime(int num)
    {
        if (num <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }

    public static bool IsNeon(int num)
    {
        int square = num * num;
        int sum = 0;
        while (square > 0)
        {
            sum += square % 10;
            square /= 10;
        }
        return sum == num;
    }

    public static bool IsSpy(int num)
    {
        int sum = 0;
        int product = 1;
        while (num > 0)
        {
            int digit = num % 10;
            sum += digit;
            product *= digit;
            num /= 10;
        }
        return sum == product;
    }

    public static bool IsAutomorphic(int num)
    {
        int square = num * num;
        string squareStr = square.ToString();
        string numStr = num.ToString();
        return squareStr.EndsWith(numStr);
    }

    public static bool IsBuzz(int num)
    {
        return num % 7 == 0 || num % 10 == 7;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(IsPrime(23)); // true
        Console.WriteLine(IsNeon(9)); // true
        Console.WriteLine(IsSpy(123)); // false
        Console.WriteLine(IsAutomorphic(5)); // true
        Console.WriteLine(IsBuzz(14)); // true
    }
}