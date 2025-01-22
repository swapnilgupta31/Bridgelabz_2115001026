using System;

public class DistanceConverter
{
    // Entry point of the program
    public static void Main(string[] args)
    {
        // Take distance in feet as input
        Console.WriteLine("Enter the distance in feet:");
        double distanceInFeet = double.Parse(Console.ReadLine());

        // Calculate distance in yards and miles
        double distanceInYards = distanceInFeet / 3;
        double distanceInMiles = distanceInYards / 1760;

        // Print the result using string concatenation
        Console.WriteLine("The distance in feet is " + distanceInFeet + 
                          ", in yards is " + distanceInYards + 
                          ", and in miles is " + distanceInMiles);
    }
}
