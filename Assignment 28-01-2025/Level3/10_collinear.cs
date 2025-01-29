using System;

public class CollinearPoints
{
    // Method to check if three points are collinear using slope formula
    public static bool ArePointsCollinearBySlope(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        // Calculate slopes for AB, BC, and AC
        double slopeAB = (y2 - y1) / (x2 - x1);
        double slopeBC = (y3 - y2) / (x3 - x2);
        double slopeAC = (y3 - y1) / (x3 - x1);

        // Points are collinear if all slopes are equal
        return slopeAB == slopeBC && slopeBC == slopeAC;
    }

    // Method to check if three points are collinear using the area of triangle formula
    public static bool ArePointsCollinearByArea(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        // Calculate the area of the triangle formed by the three points
        double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));

        // Points are collinear if the area is 0
        return area == 0;
    }

    public static void Main(string[] args)
    {
        // Take inputs for the three points
        Console.Write("Enter x1: ");
        double x1 = double.Parse(Console.ReadLine());

        Console.Write("Enter y1: ");
        double y1 = double.Parse(Console.ReadLine());

        Console.Write("Enter x2: ");
        double x2 = double.Parse(Console.ReadLine());

        Console.Write("Enter y2: ");
        double y2 = double.Parse(Console.ReadLine());

        Console.Write("Enter x3: ");
        double x3 = double.Parse(Console.ReadLine());

        Console.Write("Enter y3: ");
        double y3 = double.Parse(Console.ReadLine());

        // Check if the points are collinear using slope formula
        bool areCollinearBySlope = ArePointsCollinearBySlope(x1, y1, x2, y2, x3, y3);
        if (areCollinearBySlope)
        {
            Console.WriteLine("The points are collinear using the slope formula.");
        }
        else
        {
            Console.WriteLine("The points are not collinear using the slope formula.");
        }

        // Check if the points are collinear using area formula
        bool areCollinearByArea = ArePointsCollinearByArea(x1, y1, x2, y2, x3, y3);
        if (areCollinearByArea)
        {
            Console.WriteLine("The points are collinear using the area formula.");
        }
        else
        {
            Console.WriteLine("The points are not collinear using the area formula.");
        }
    }
}
