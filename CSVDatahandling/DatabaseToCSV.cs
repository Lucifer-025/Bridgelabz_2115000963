using System;
using System.Data.SqlClient;
using System.IO;


class DatabaseToCSV
{
    static void Main()
    {
        string connectionString = "your_connection_string_here";
        string filePath = "employee_report.csv";


        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            var command = new SqlCommand("SELECT EmployeeID, Name, Department, Salary FROM Employees", connection);
            using (var reader = command.ExecuteReader())
            {
                using (var writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("EmployeeID,Name,Department,Salary");


                    while (reader.Read())
                    {
                        writer.WriteLine($"{reader["EmployeeID"]},{reader["Name"]},{reader["Department"]},{reader["Salary"]}");
                    }
                }
            }
        }


        Console.WriteLine($"Data exported to {filePath}");
    }
}
