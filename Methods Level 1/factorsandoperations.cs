using System;

class factorsandoperations
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int[] factors = FindFactors(number);
        Console.WriteLine("Factors: " + string.Join(", ", factors));

        int sum = SumOfFactors(factors);
        Console.WriteLine("Sum of factors: " + sum);

        int product = ProductOfFactors(factors);
        Console.WriteLine("Product of factors: " + product);

        int sumOfSquares = SumOfSquaresOfFactors(factors);
        Console.WriteLine("Sum of squares of factors: " + sumOfSquares);
    }

    static int[] FindFactors(int num)
    {
        int count = 0;

        // Count the number of factors
        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0) count++;
        }

        // Store the factors in an array
        int[] factors = new int[count];
        int index = 0;
        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                factors[index++] = i;
            }
        }
        return factors;
    }

    static int SumOfFactors(int[] factors)
    {
        int sum = 0;
        foreach (int factor in factors)
        {
            sum += factor;
        }
        return sum;
    }

    static int ProductOfFactors(int[] factors)
    {
        int product = 1;
        foreach (int factor in factors)
        {
            product *= factor;
        }
        return product;
    }

    static int SumOfSquaresOfFactors(int[] factors)
    {
        int sumOfSquares = 0;
        foreach (int factor in factors)
        {
            sumOfSquares 
