using System;

class VotingEligibility
{
    static void Main()
    {
        int[] ages = new int[10];
        
        Console.WriteLine("Enter the age of 10 students:");
        for (int i = 0; i < ages.Length; i++)
        {
            Console.Write($"Enter age of student {i + 1}: ");
            int age = int.Parse(Console.ReadLine());
            if (age < 0)
            {
                Console.WriteLine("Invalid age. Please enter again.");
                i--;
                continue;
            }
            ages[i] = age;
        }

        foreach (int age in ages)
        {
            if (age >= 18)
                Console.WriteLine($"The student with the age {age} can vote.");
            else
                Console.WriteLine($"The student with the age {age} cannot vote.");
        }
    }
}
