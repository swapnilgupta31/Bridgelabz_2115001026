using System;

public class EuclideanDistance
{
    // Method to calculate the Euclidean distance between two points (x1, y1) and (x2, y2)
    public static double CalculateDistance(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }

    // Method to calculate the equation of a line given two points (x1, y1) and (x2, y2)
    public static double[] CalculateLineEquation(double x1, double y1, double x2, double y2)
    {
        // Calculate slope (m) using the formula m = (y2 - y1) / (x2 - x1)
        double m = (y2 - y1) / (x2 - x1);

        // Calculate y-intercept (b) using the formula b = y1 - m * x1
        double b = y1 - m * x1;

        return new double[] { m, b };
    }

    public static void Main(string[] args)
    {
        // Take inputs for the two points
        Console.Write("Enter x1: ");
        double x1 = double.Parse(Console.ReadLine());

        Console.Write("Enter y1: ");
        double y1 = double.Parse(Console.ReadLine());

        Console.Write("Enter x2: ");
        double x2 = double.Parse(Console.ReadLine());

        Console.Write("Enter y2: ");
        double y2 = double.Parse(Console.ReadLine());

        // Calculate Euclidean distance
        double distance = CalculateDistance(x1, y1, x2, y2);
        Console.WriteLine("Euclidean Distance: " + distance);

        // Calculate the equation of the line
        double[] lineEquation = CalculateLineEquation(x1, y1, x2, y2);
        Console.WriteLine("Equation of the line: y = " + lineEquation[0] + "x + " + lineEquation[1]);
    }
}
