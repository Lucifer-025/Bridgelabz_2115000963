using System;
using System.Collections.Generic;

class Faculty
{
    public string Name;
    public Faculty(string name)
    {
        Name = name;
    }
}

class Department
{
    public string Name;
    public Department(string name)
    {
        Name = name;
    }
}

class University
{
    public string Name;
    public List<Department> departments = new List<Department>();
    public List<Faculty> faculties = new List<Faculty>();

    public University(string name)
    {
        Name = name;
    }

    public void AddDepartment(Department dept)
    {
        departments.Add(dept);
    }

    public void AddFaculty(Faculty faculty)
    {
        faculties.Add(faculty);
    }
}

class Program
{
    static void Main()
    {
        University university = new University("ABC University");
        Department dept = new Department("Computer Science");
        Faculty faculty = new Faculty("Dr. Smith");

        university.AddDepartment(dept);
        university.AddFaculty(faculty);
    }
}
