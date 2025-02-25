
using System;
using System.IO;

class StudentFilter
{
    static void Main()
    {
        string filePath = "students.csv";

        using (var reader = new StreamReader(filePath))
        {
            reader.ReadLine(); // Skip header
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                int marks = int.Parse(values[3]);

                if (marks > 80)
                {
                    Console.WriteLine($"ID: {values[0]}, Name: {values[1]}, Marks: {marks}");
                }
            }
        }
    }
}

