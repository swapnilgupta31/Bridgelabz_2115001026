using System;

public class DistanceConverter
{
    public static void Main(string[] args)
    {
        // Create a variable to store kilometers (using double for decimals)
        double km;

        // Prompt user for input
        Console.Write("Enter the distance in kilometers: ");
        
        // Take user input for kilometers
        km = double.Parse(Console.ReadLine());

        // Convert kilometers to miles using the formula (1 mile = 1.6 km)
        double miles = km / 1.6;

        // Output the result
        Console.WriteLine($"The total miles is {miles:F2} mile(s) for the given {km:F2} km.");
    }
}
