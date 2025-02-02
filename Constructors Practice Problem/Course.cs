using System;

class Course
{
    public string CourseName;
    public int Duration;
    public double Fee;
    public static string InstituteName = "ABC Institute";

    public Course(string courseName, int duration, double fee)
    {
        CourseName = courseName;
        Duration = duration;
        Fee = fee;
    }

    public void DisplayCourseDetails()
    {
        Console.WriteLine($"Course: {CourseName}, Duration: {Duration} months, Fee: {Fee}, Institute: {InstituteName}");
    }

    public static void UpdateInstituteName(string newName)
    {
        InstituteName = newName;
    }

    static void Main()
    {
        Course c1 = new Course("Java", 6, 500);
        c1.DisplayCourseDetails();

        Course.UpdateInstituteName("XYZ Academy");
        Course c2 = new Course("Python", 4, 400);
        c2.DisplayCourseDetails();
    }
}
