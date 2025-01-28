using System;

class EmployeeBonus
{
    static void Main(string[] args)
    {
        int numEmployees = 10;
        int[,] employeeData = GenerateEmployeeData(numEmployees);
        int[,] updatedData = CalculateBonusAndNewSalary(employeeData);
        DisplayResults(employeeData, updatedData);
    }

    static int[,] GenerateEmployeeData(int count)
    {
        Random random = new Random();
        int[,] data = new int[count, 2];
        for (int i = 0; i < count; i++)
        {
            data[i, 0] = random.Next(20000, 99999); // Random salary
            data[i, 1] = random.Next(1, 15);       // Random years of service
        }
        return data;
    }

    static int[,] CalculateBonusAndNewSalary(int[,] data)
    {
        int[,] updatedData = new int[data.GetLength(0), 3];
        for (int i = 0; i < data.GetLength(0); i++)
        {
            int salary = data[i, 0];
            int years = data[i, 1];
            double bonusRate = years > 5 ? 0.05 : 0.02;
            int bonus = (int)(salary * bonusRate);
            updatedData[i, 0] = salary;
            updatedData[i, 1] = salary + bonus;
            updatedData[i, 2] = bonus;
        }
        return updatedData;
    }

    static void DisplayResults(int[,] originalData, int[,] updatedData)
    {
        Console.WriteLine("Employee\tOld Salary\tYears of Service\tNew Salary\tBonus");
        int totalOld = 0, totalNew = 0, totalBonus = 0;
        for (int i = 0; i < originalData.GetLength(0); i++)
        {
            totalOld += updatedData[i, 0];
            totalNew += updatedData[i, 1];
            totalBonus += updatedData[i, 2];
            Console.WriteLine($"{i + 1}\t\t{updatedData[i, 0]}\t\t{originalData[i, 1]}\t\t\t{updatedData[i, 1]}\t\t{updatedData[i, 2]}");
        }
        Console.WriteLine($"Total\t\t{totalOld}\t\t\t\t\t{totalNew}\t\t{totalBonus}");
    }
}
