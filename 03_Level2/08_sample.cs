using System;

public class SampleProgram2
{
    // Entry point of the program
    public static void Main(string[] args)
    {
        // Take user inputs for name and cities
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();
        
        Console.WriteLine("Enter the starting city:");
        string fromCity = Console.ReadLine();
        
        Console.WriteLine("Enter the via city:");
        string viaCity = Console.ReadLine();
        
        Console.WriteLine("Enter the destination city:");
        string toCity = Console.ReadLine();
        
        // Take user inputs for distances
        Console.WriteLine("Enter the distance from the starting city to the via city (in miles):");
        double fromToVia = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the distance from the via city to the destination city (in miles):");
        double viaToFinalCity = double.Parse(Console.ReadLine());
        
        // Take the time taken for the journey
        Console.WriteLine("Enter the time taken for the entire journey (in hours):");
        double timeTaken = double.Parse(Console.ReadLine());
        
        // Calculate the total distance and average speed
        double totalDistance = fromToVia + viaToFinalCity;
        double averageSpeed = totalDistance / timeTaken;

        // Output the results using string concatenation
        Console.WriteLine("The results of the trip are: " + name + ", " + totalDistance + " miles, and average speed is " + averageSpeed + " miles per hour.");
    }
}
