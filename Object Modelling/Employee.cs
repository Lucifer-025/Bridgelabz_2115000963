using System;
using System.Collections.Generic;

class Employee
{
    public string Name;
    public Employee(string name)
	{	
	this.Name = name;
}
}

class Department
{
    public string Name;
    private List<Employee> employees = new List<Employee>();

    public Department(string name)
    {
        this.Name = name;
    }

    public void AddEmployee(Employee employee)
    {
        employees.Add(employee);
    }
}

class Company
{
    public string Name;
    private List<Department> departments = new List<Department>();

    public Company(string name)
    {
        this.Name = name;
    }

    public void AddDepartment(Department department)
    {
        departments.Add(department);
    }
}

class Program
{
    static void Main()
    {
        Company company = new Company("Capgemini");
        Department dept = new Department("IT");
        dept.AddEmployee(new Employee("Shivansh"));
        dept.AddEmployee(new Employee("Udit"));

        company.AddDepartment(dept);
    }
}
