using System;

class Employee
{
    public int EmployeeID;
    protected string Department;
    private double Salary;

    public Employee(int employeeID, string department, double salary)
    {
        EmployeeID = employeeID;
        Department = department;
        Salary = salary;
    }

    public void SetSalary(double salary)
    {
        Salary = salary;
    }

    public double GetSalary()
    {
        return Salary;
    }
}

class Manager : Employee
{
    public Manager(int employeeID, string department, double salary) : base(employeeID, department, salary) { }

    public void DisplayManagerDetails()
    {
        Console.WriteLine($"Manager - ID: {EmployeeID}, Department: {Department}");
    }
}

class Program
{
    static void Main()
    {
        Manager m1 = new Manager(1001, "IT", 75000);
        m1.DisplayManagerDetails();
    }
}
