using System;

public class SquareSide
{
    // Entry point of the program
    public static void Main(string[] args)
    {
        // Take perimeter as input
        Console.WriteLine("Enter the perimeter of the square:");
        double perimeter = double.Parse(Console.ReadLine());

        // Calculate side of the square
        double side = perimeter / 4;

        // Print the result using string concatenation
        Console.WriteLine("The length of the side is " + side + " whose perimeter is " + perimeter);
    }
}
