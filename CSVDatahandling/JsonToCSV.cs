using System;
using System.IO;
using System.Text.Json;


class JsonToCSV
{
    static void Main()
    {
        string jsonFile = "students.json";
        string csvFile = "students.csv";


        var jsonData = File.ReadAllText(jsonFile);
        var students = JsonSerializer.Deserialize<Student[]>(jsonData);


        using (var writer = new StreamWriter(csvFile))
        {
            writer.WriteLine("ID,Name,Age,Marks");
            foreach (var student in students)
            {
                writer.WriteLine($"{student.ID},{student.Name},{student.Age},{student.Marks}");
            }
        }


        Console.WriteLine("JSON converted to CSV successfully.");
    }
}


public class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
}
