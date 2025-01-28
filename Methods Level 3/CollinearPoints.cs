using System;

class CollinearPoints
{
    static void Main(string[] args)
    {
        // Points A(2,4), B(4,6), C(6,8)
        int x1 = 2, y1 = 4, x2 = 4, y2 = 6, x3 = 6, y3 = 8;

        Console.WriteLine("Using Slope Formula:");
        if (CheckCollinearBySlope(x1, y1, x2, y2, x3, y3))
            Console.WriteLine("The points are collinear.");
        else
            Console.WriteLine("The points are not collinear.");

        Console.WriteLine("\nUsing Area of Triangle Formula:");
        if (CheckCollinearByArea(x1, y1, x2, y2, x3, y3))
            Console.WriteLine("The points are collinear.");
        else
            Console.WriteLine("The points are not collinear.");
    }

    static bool CheckCollinearBySlope(int x1, int y1, int x2, int y2, int x3, int y3)
    {
        double slopeAB = (double)(y2 - y1) / (x2 - x1);
        double slopeBC = (double)(y3 - y2) / (x3 - x2);
        double slopeAC = (double)(y3 - y1) / (x3 - x1);

        return slopeAB == slopeBC && slopeBC == slopeAC;
    }

    static bool CheckCollinearByArea(int x1, int y1, int x2, int y2, int x3, int y3)
    {
        double area = 0.5 * Math.Abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
        return area == 0;
    }
}
