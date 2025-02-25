using System;
using System.IO;
using System.Text.RegularExpressions;


class CSVValidator
{
    static void Main()
    {
        string filePath = "contacts.csv";
        var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        var phoneRegex = new Regex(@"^\d{10}$");


        using (var reader = new StreamReader(filePath))
        {
            reader.ReadLine(); // Skip header
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');


                bool isEmailValid = emailRegex.IsMatch(values[1]);
                bool isPhoneValid = phoneRegex.IsMatch(values[2]);


                if (!isEmailValid || !isPhoneValid)
                {
                    Console.WriteLine($"Invalid record: {line}");
                }
            }
        }
    }
}
