using System;
using System.Collections.Generic;

class Course
{
    public string CourseName;
    public List<Student> students = new List<Student>();

    public Course(string courseName)
    {
        CourseName = courseName;
    }

    public void Enroll(Student student)
    {
        students.Add(student);
    }
}

class Student
{
    public string Name;
    public List<Course> courses = new List<Course>();

    public Student(string name)
    {
        Name = name;
    }

    public void EnrollInCourse(Course course)
    {
        courses.Add(course);
        course.Enroll(this);
    }
}

class School
{
    public string Name;
    public List<Student> students = new List<Student>();

    public School(string name)
    {
        Name = name;
    }

    public void AddStudent(Student student)
    {
        students.Add(student);
    }
}

class Program
{
    static void Main()
    {
        School school = new School("ST Thomas College");
        Student student = new Student("Shivansh");
        Course course = new Course("Mathematics");

        school.AddStudent(student);
        student.EnrollInCourse(course);
    }
}
