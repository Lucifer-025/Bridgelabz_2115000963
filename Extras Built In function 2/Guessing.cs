using System;

class Guessing
{
    static void Main()
    {
        int low = 1, high = 100, guess;
        string response;

        Console.WriteLine("Think of a number between 1 and 100.");
        
        while (true)
        {
            guess = (low + high) / 2;
            Console.WriteLine($"Is your number {guess}? (Enter 'high', 'low', or 'correct'):");
            response = Console.ReadLine().ToLower();

            if (response == "correct")
            {
                Console.WriteLine("Yay! The computer guessed your number!");
                break;
            }
            else if (response == "high")
                high = guess - 1;
            else if (response == "low")
                low = guess + 1;
            else
                Console.WriteLine("Invalid input. Please enter 'high', 'low', or 'correct'.");
        }
    }
}
