using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


class MergeCSVFiles
{
    static void Main()
    {
        var students1 = File.ReadAllLines("students1.csv").Skip(1);
        var students2 = File.ReadAllLines("students2.csv").Skip(1);
        var merged = new List<string> { "ID,Name,Age,Marks,Grade" };


        var data1 = students1.Select(line => line.Split(',')).ToDictionary(values => values[0]);
        foreach (var line in students2)
        {
            var values = line.Split(',');
            if (data1.ContainsKey(values[0]))
            {
                merged.Add($"{values[0]},{data1[values[0]][1]},{data1[values[0]][2]},{values[1]},{values[2]}");
            }
        }


        File.WriteAllLines("merged_students.csv", merged);
        Console.WriteLine("Files merged successfully!");
    }
}
