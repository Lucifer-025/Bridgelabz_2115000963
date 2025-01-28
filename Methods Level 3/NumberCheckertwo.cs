using System;

public class NumberCheckertwo
{
    public static int[] GetFactors(int num)
    {
        int count = 0;
        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0) count++;
        }
        int[] factors = new int[count];
        int j = 0;
        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0) factors[j++] = i;
        }
        return factors;
    }

    public static int GetGreatestFactor(int num)
    {
        int[] factors = GetFactors(num);
        int max = factors[0];
        for (int i = 1; i < factors.Length; i++)
        {
            if (factors[i] > max) max = factors[i];
        }
        return max;
    }

    public static int GetSumOfFactors(int num)
    {
        int[] factors = GetFactors(num);
        int sum = 0;
        for (int i = 0; i < factors.Length; i++)
        {
            sum += factors[i];
        }
        return sum;
    }

    public static int GetProductOfFactors(int num)
    {
        int[] factors = GetFactors(num);
        int product = 1;
        for (int i = 0; i < factors.Length; i++)
        {
            product *= factors[i];
        }
        return product;
    }

    public static double GetProductOfCubeOfFactors(int num)
    {
        int[] factors = GetFactors(num);
        double product = 1;
        for (int i = 0; i < factors.Length; i++)
        {
            product *= Math.Pow(factors[i], 3);
        }
        return product;
    }

    public static bool IsPerfect(int num)
    {
        int sum = GetSumOfFactors(num);
        return sum == num;
    }

    public static bool IsAbundant(int num)
    {
        int sum = GetSumOfFactors(num);
        return sum > num;
    }

    public static bool IsDeficient(int num)
    {
        int sum = GetSumOfFactors(num);
        return sum < num;
    }

    public static bool IsStrong(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            int digit = num % 10;
            sum += Factorial(digit);
            num /= 10;
        }
        return sum == num;
    }

    public static int Factorial(int num)
    {
        int result = 1;
        for (int i = 2; i <= num; i++)
        {
            result *= i;
        }
        return result;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(GetGreatestFactor(12)); // 6
        Console.WriteLine(GetSumOfFactors(12)); // 28
        Console.WriteLine(GetProductOfFactors(12)); // 144
        Console.WriteLine(GetProductOfCubeOfFactors(12)); // 1728
        Console.WriteLine(IsPerfect(6)); // true
        Console.WriteLine(IsAbundant(12)); // true
        Console.WriteLine(IsDeficient(10)); // true
        Console.WriteLine(IsStrong(145)); // true
    }
}