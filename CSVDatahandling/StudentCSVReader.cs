using System;
using System.IO;


class StudentCSVReader
{
    static void Main()
    {
        string filePath = "students.csv";


        using (var reader = new StreamReader(filePath))
        {
            // Skip the header row
            reader.ReadLine(); 
            
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');


                Console.WriteLine($"ID: {values[0]}, Name: {values[1]}, Age: {values[2]}, Marks: {values[3]}");
            }
        }
    }
}
