using System;

public class TriangleArea
{
    // Entry point of the program
    public static void Main(string[] args)
    {
        // Take base as input
        Console.WriteLine("Enter the base of the triangle in centimeters:");
        double baseCm = double.Parse(Console.ReadLine());

        // Take height as input
        Console.WriteLine("Enter the height of the triangle in centimeters:");
        double heightCm = double.Parse(Console.ReadLine());

        // Calculate area in square centimeters
        double areaCm2 = 0.5 * baseCm * heightCm;

        // Convert area to square inches (1 cm² = 0.155 square inches)
        double areaIn2 = areaCm2 * 0.155;

        // Print the result using string concatenation
        Console.WriteLine("The area of the triangle in square centimeters is " + areaCm2 + " while in square inches is " + areaIn2);
    }
}
