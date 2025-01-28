using System;

class Studentvotechecker
{
    public static void Main(string[] args)
    {
        int[] ages = new int[10];
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter age of student {i + 1}: ");
            ages[i] = int.Parse(Console.ReadLine());
            Console.WriteLine(CanStudentVote(ages[i]) ? "Can vote." : "Cannot vote.");
        }
    }

    public static bool CanStudentVote(int age)
    {
        if (age < 0) return false;
        return age >= 18;
    }
}
