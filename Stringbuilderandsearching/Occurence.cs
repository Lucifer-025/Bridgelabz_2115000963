using System;
using System.IO;

class Occurence
{
    static void Main()
    {
        string filePath = "sample.txt"; // Change to your file path
        string searchWord = "hello"; // Word to count
        int count = 0;

        using (StreamReader sr = new StreamReader(filePath))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                foreach (string word in words)
                {
                    if (word.Equals(searchWord))
                    {
                        count++;
                    }
                }
            }
        }

        Console.WriteLine("The word"+searchWord+ "appears" +count+" times.");
    }}
