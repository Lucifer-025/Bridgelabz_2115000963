using System;
using System.IO;
using System.Linq;


class SortEmployeesBySalary
{
    static void Main()
    {
        string filePath = "employees.csv";


        var lines = File.ReadAllLines(filePath).Skip(1);
        var sortedLines = lines.OrderByDescending(line => double.Parse(line.Split(',')[3])).Take(5);


        foreach (var line in sortedLines)
        {
            Console.WriteLine(line);
        }
    }
}
