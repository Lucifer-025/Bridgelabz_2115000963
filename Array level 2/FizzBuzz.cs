using System;

class FizzBuzz
{
    static void Main()
    {
        Console.Write("Enter a positive number: ");
        int number = int.Parse(Console.ReadLine());

        if (number <= 0)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        string[] results = new string[number + 1];

        for (int i = 1; i <= number; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                results[i] = "FizzBuzz";
            else if (i % 3 == 0)
                results[i] = "Fizz";
            else if (i % 5 == 0)
                results[i] = "Buzz";
            else
                results[i] = i.ToString();
        }

        Console.WriteLine("FizzBuzz Results:");
        for (int i = 1; i < results.Length; i++)
        {
            Console.WriteLine($"Position {i} = {results[i]}");
        }
    }
}
