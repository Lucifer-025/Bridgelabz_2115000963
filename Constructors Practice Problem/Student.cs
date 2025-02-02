using System;

class Student
{
    public int RollNumber;
    protected string Name;
    private double CGPA;

    public Student(int rollNumber, string name, double cgpa)
    {
        RollNumber = rollNumber;
        Name = name;
        CGPA = cgpa;
    }

    public void SetCGPA(double cgpa)
    {
        CGPA = cgpa;
    }

    public double GetCGPA()
    {
        return CGPA;
    }
}

class PostgraduateStudent : Student
{
    public PostgraduateStudent(int rollNumber, string name, double cgpa) : base(rollNumber, name, cgpa) { }

    public void DisplayName()
    {
        Console.WriteLine($"Postgraduate Student: {Name}");
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student(101, "John", 3.8);
        s1.SetCGPA(4.0);
        Console.WriteLine($"CGPA: {s1.GetCGPA()}");

        PostgraduateStudent p1 = new PostgraduateStudent(102, "Alice", 3.9);
        p1.DisplayName();
    }
}
