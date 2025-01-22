using System;

public class AthleteRounds
{
    // Entry point of the program
    public static void Main(string[] args)
    {
        // Take user input for the sides of the triangle
        Console.WriteLine("Enter the length of side 1 of the triangle (in meters):");
        double side1 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the length of side 2 of the triangle (in meters):");
        double side2 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the length of side 3 of the triangle (in meters):");
        double side3 = double.Parse(Console.ReadLine());
        
        // Calculate the perimeter of the triangle
        double perimeter = side1 + side2 + side3;
        
        // Convert the distance the athlete wants to run to meters (5 km = 5000 meters)
        double targetDistance = 5000;
        
        // Calculate the number of rounds the athlete must complete
        double rounds = targetDistance / perimeter;
        
        // Output the result using string concatenation
        Console.WriteLine("The total number of rounds the athlete will run is " + rounds + " to complete 5 km.");
    }
}
