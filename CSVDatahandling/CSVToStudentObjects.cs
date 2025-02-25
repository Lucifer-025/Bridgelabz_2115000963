using System;
using System.Collections.Generic;
using System.IO;

class CSVToStudentObjects
{
    static void Main()
    {
        string filePath = "students.csv";
        var students = new List<Student>();

        using (var reader = new StreamReader(filePath))
        {
            reader.ReadLine(); // Skip header
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                var student = new Student
                {
                    ID = int.Parse(values[0]),
                    Name = values[1],
                    Age = int.Parse(values[2]),
                    Marks = int.Parse(values[3])
                };

                students.Add(student);
            }
        }

        Console.WriteLine("Student Records:");
        students.ForEach(student => Console.WriteLine(student));
    }
}

public class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }

    public override string ToString()
    {
        return $"ID: {ID}, Name: {Name}, Age: {Age}, Marks: {Marks}";
    }
}
