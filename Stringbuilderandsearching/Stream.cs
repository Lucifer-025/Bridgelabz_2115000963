using System;
using System.IO;

class Stream
{
    static void Main()
    {
        string filePath = "output.txt";

        using (StreamWriter sw = new StreamWriter(filePath))
        {
            Console.WriteLine("Enter text to write to file (type 'exit' to stop):");
            
            string input;
            while ((input = Console.ReadLine()) != "exit")
            {
                sw.WriteLine(input);
            }
        }

        Console.WriteLine("Data written to file successfully.");
    }
}

