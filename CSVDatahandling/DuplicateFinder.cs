using System;
using System.IO;
using System.Collections.Generic;


class DuplicateFinder
{
    static void Main()
    {
        string filePath = "students.csv";
        var seenIds = new HashSet<string>();
        var duplicates = new List<string>();


        using (var reader = new StreamReader(filePath))
        {
            reader.ReadLine(); // Skip header
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                string id = values[0];


                if (!seenIds.Add(id))
                {
                    duplicates.Add(line);
                }
            }
        }


        Console.WriteLine("Duplicate Records:");
        duplicates.ForEach(Console.WriteLine);
    }
}
