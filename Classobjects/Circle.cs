using System;

class Circle
{
    private double radius;

    public Circle(double r)
    {
        radius = r;
    }

    public double Area()
    {
        return Math.PI * radius * radius;
    }

    public double Circumference()
    {
        return 2 * Math.PI * radius;
    }

    public void Display()
    {
        Console.WriteLine("Radius: " + radius);
        Console.WriteLine("Area: " + Area().ToString("F2"));
        Console.WriteLine("Circumference: " + Circumference().ToString("F2"));
    }

    static void Main()
    {
        Circle circle = new Circle(5);
        circle.Display();
    }
}
