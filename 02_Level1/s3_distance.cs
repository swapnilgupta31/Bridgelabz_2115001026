using System;

public class distance
{
    // Entry point of the program
    public static void Main(string[] args)
    {
        // Distance to be converted
        double disKm = 10.8;

        // Calculate distance in miles (1 km = 1.6 miles)
        double disMiles = disKm * 1.6;

        // Output the distance in miles
        Console.WriteLine("The distance " + disKm + " km in miles is " + disMiles);
    }
}
