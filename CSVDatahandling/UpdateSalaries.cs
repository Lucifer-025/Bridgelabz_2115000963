using System;
using System.IO;
using System.Collections.Generic;


class UpdateSalaries
{
    static void Main()
    {
        string filePath = "employees.csv";
        var lines = new List<string>();
        lines.Add("ID,Name,Department,Salary");


        using (var reader = new StreamReader(filePath))
        {
            reader.ReadLine(); // Skip header
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');


                if (values[2] == "IT")
                {
                    double salary = double.Parse(values[3]) * 1.1;
                    line = $"{values[0]},{values[1]},{values[2]},{salary:F2}";
                }


                lines.Add(line);
            }
        }


        File.WriteAllLines("updated_employees.csv", lines);
        Console.WriteLine("Salaries updated and saved to updated_employees.csv.");
    }
}
