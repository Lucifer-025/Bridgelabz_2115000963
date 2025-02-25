using System;
using System.IO;


class EmployeeCSVWriter
{
    static void Main()
    {
        string filePath = "employees.csv";
        string[] employees = {
            "ID,Name,Department,Salary",
            "1,Shivansh,IT,5000",
            "2,Udit,HR,5500",
            "3,Vikas,Finance,6000",
            "4,Sarah,IT,7000",
            "5,Pauly,Marketing,6500"
        };


        File.WriteAllLines(filePath, employees);
        Console.WriteLine("Data written to employees.csv successfully!");
    }
}
