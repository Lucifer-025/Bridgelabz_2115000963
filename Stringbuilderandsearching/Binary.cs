using System;
using System.IO;

class Binary
{
    static void Main()
    {
        string filePath = "binaryfile.bin"; // Change to your binary file path

        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        using (StreamReader sr = new StreamReader(fs))
        {
            string content = sr.ReadToEnd();
            Console.WriteLine(content);
        }
    }
}
