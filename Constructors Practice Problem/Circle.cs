using System;

class Circle
{
    public double Radius;

    public Circle() : this(1.0) { }

    
    public Circle(double radius)
    {
        Radius = radius;
    }

    public void DisplayRadius()
    {
        Console.WriteLine($"Radius: {Radius}");
    }

    static void Main()
    {
        Circle c1 = new Circle();
        Circle c2 = new Circle(5.5);

        c1.DisplayRadius();
        c2.DisplayRadius();
    }
}
