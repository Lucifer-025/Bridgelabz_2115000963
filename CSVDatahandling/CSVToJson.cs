using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

class CSVToJson
{
    static void Main()
    {
        string csvFile = "students.csv";
        string jsonFile = "students.json";
        var students = new List<Student>();

        using (var reader = new StreamReader(csvFile))
        {
            reader.ReadLine(); // Skip header
            while (!reader.EndOfStream)
            {
                var values = reader.ReadLine().Split(',');
                students.Add(new Student
                {
                    ID = int.Parse(values[0]),
                    Name = values[1],
                    Age = int.Parse(values[2]),
                    Marks = int.Parse(values[3])
                });
            }
        }

        var jsonData = JsonSerializer.Serialize(students, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(jsonFile, jsonData);

        Console.WriteLine("CSV converted to JSON successfully.");
    }
}

public class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
}

