
using System;
using System.IO;

class EmployeeSearch
{
    static void Main()
    {
        string filePath = "employees.csv";
        Console.Write("Enter employee name to search: ");
        string searchName = Console.ReadLine();

        using (var reader = new StreamReader(filePath))
        {
            reader.ReadLine(); // Skip header
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                if (values[1].Equals(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Department: {values[2]}, Salary: {values[3]}");
                    return;
                }
            }
        }

        Console.WriteLine("Employee not found.");
    }
}

