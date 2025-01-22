using System;

class Program6
{
    static void Main()
    {
        Console.Write("Enter the Principal amount: ");
        double principal = double.Parse(Console.ReadLine());

        Console.Write("Enter the Rate of interest: ");
        double rate = double.Parse(Console.ReadLine());

        Console.Write("Enter the Time in years: ");
        double time = double.Parse(Console.ReadLine());

        double simpleInterest = (principal * rate * time) / 100;
        Console.WriteLine("The Simple Interest is: " + simpleInterest);
    }
}
