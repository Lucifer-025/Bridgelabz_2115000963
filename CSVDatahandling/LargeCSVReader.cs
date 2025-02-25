using System;
using System.IO;


class LargeCSVReader
{
    static void Main()
    {
        string filePath = "large_file.csv";
        int chunkSize = 100;
        int totalRecords = 0;


        using (var reader = new StreamReader(filePath))
        {
            reader.ReadLine(); // Skip header
            string line;
            int count = 0;


            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
                count++;
                totalRecords++;


                if (count == chunkSize)
                {
                    Console.WriteLine($"Processed {totalRecords} records so far...");
                    count = 0;
                }
            }
        }


        Console.WriteLine($"Finished processing {totalRecords} records.");
    }
}
