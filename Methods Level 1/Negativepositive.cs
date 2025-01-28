using System;

class Negativepositive
{
    static void Main(string[] args)
    {
        int[] numbers = new int[5];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());

            if (IsPositive(numbers[i]))
            {
                Console.WriteLine($"{numbers[i]} is Positive.");
                Console.WriteLine(IsEven(numbers[i]) ? "It is Even." : "It is Odd.");
            }
            else
            {
                Console.WriteLine($"{numbers[i]} is Negative.");
            }
        }

        int comparisonResult = Compare(numbers[0], numbers[4]);
        string comparison = comparisonResult == 0 ? "equal" : (comparisonResult > 0 ? "greater" : "less");
        Console.WriteLine($"First element is {comparison} than the last element.");
    }

    static bool IsPositive(int num) => num >= 0;

    static bool IsEven(int num) => num % 2 == 0;

    static int Compare(int num1, int num2) => num1.CompareTo(num2);
}
