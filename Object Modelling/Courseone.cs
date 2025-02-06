using System;
using System.Collections.Generic;

class Courseone
{
    public string Name;
    public List<Student> students = new List<Student>();
    public Professor professor;

    public Courseone(string name)
    {
        Name = name;
    }

    public void EnrollStudent(Student student)
    {
        students.Add(student);
    }

    public void AssignProfessor(Professor prof)
    {
        professor = prof;
    }

    public void ShowCourseDetails()
    {
        Console.WriteLine("Course: " + Name);
        Console.WriteLine("Professor: " + (professor != null ? professor.Name : "None"));
        Console.WriteLine("Enrolled Students:");
        foreach (var student in students)
        {
            Console.WriteLine(" - " + student.Name);
        }
    }
}

class Student
{
    public string Name;
    public List<Courseone> courses = new List<Courseone>();

    public Student(string name)
    {
        Name = name;
    }

    public void EnrollCourse(Courseone course)
    {
        courses.Add(course);
        course.EnrollStudent(this);
    }
}

class Professor
{
    public string Name;

    public Professor(string name)
    {
        Name = name;
    }

    public void AssignToCourse(Courseone course)
    {
        course.AssignProfessor(this);
    }
}

class Program
{
    static void Main()
    {
        Student student1 = new Student("Shivansh");
        Student student2 = new Student("Udit");
        Professor professor = new Professor("Mayank Saxena");
        Courseone course = new Courseone("Computer Science");

        student1.EnrollCourse(course);
        student2.EnrollCourse(course);
        professor.AssignToCourse(course);

        course.ShowCourseDetails();
    }
}
