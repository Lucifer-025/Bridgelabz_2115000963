using System;
using System.IO;


class CSVRowCounter
{
    static void Main()
    {
        string filePath = "students.csv";
        int count = 0;


        using (var reader = new StreamReader(filePath))
        {
            reader.ReadLine(); // Skip header
            while (!reader.EndOfStream)
            {
                reader.ReadLine();
                count++;
            }
        }


        Console.WriteLine($"Total records (excluding header): {count}");
    }
}
