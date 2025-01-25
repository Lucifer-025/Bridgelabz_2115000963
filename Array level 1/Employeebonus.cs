using System;

class Program
{
    static void Main(string[] args)
    {
        const int numEmployees = 10;
        double[] salaries = new double[numEmployees];
        double[] yearsOfService = new double[numEmployees];
        double[] bonuses = new double[numEmployees];
        double[] newSalaries = new double[numEmployees];

        double totalOldSalary = 0, totalBonus = 0, totalNewSalary = 0;

        // Input salaries and years of service
        for (int i = 0; i < numEmployees; i++)
        {
            Console.WriteLine($"Enter the salary of employee {i + 1}:");
            while (!double.TryParse(Console.ReadLine(), out salaries[i]) || salaries[i] <= 0)
            {
                Console.WriteLine("Invalid input. Enter a positive number for salary:");
            }

            Console.WriteLine($"Enter the years of service for employee {i + 1}:");
            while (!double.TryParse(Console.ReadLine(), out yearsOfService[i]) || yearsOfService[i] < 0)
            {
                Console.WriteLine("Invalid input. Enter a non-negative number for years of service:");
            }
        }

        // Calculate bonuses, new salaries, and totals
        for (int i = 0; i < numEmployees; i++)
        {
            bonuses[i] = yearsOfService[i] > 5 ? salaries[i] * 0.05 : salaries[i] * 0.02;
            newSalaries[i] = salaries[i] + bonuses[i];

            totalOldSalary += salaries[i];
            totalBonus += bonuses[i];
            totalNewSalary += newSalaries[i];
        }

        // Display results
        Console.WriteLine("\nEmployee Details:");
        for (int i = 0; i < numEmployees; i++)
        {
            Console.WriteLine($"Employee {i + 1}: Old Salary = {salaries[i]:C}, Bonus = {bonuses[i]:C}, New Salary = {newSalaries[i]:C}");
        }

        Console.WriteLine($"\nTotal Old Salary: {totalOldSalary:C}");
        Console.WriteLine($"Total Bonus Payout: {totalBonus:C}");
        Console.WriteLine($"Total New Salary: {totalNewSalary:C}");
    }
}
