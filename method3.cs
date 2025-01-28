using System;
public class UnitConverter
{
    // Method to convert kilometers to miles
    public double ConvertKmToMiles(double km)
    {
        double kmToMilesFactor = 0.621371;
        return km * kmToMilesFactor;
    }

    public static void Main(string[] args)
    {
        // Create a UnitConverter object
        UnitConverter unitConverter = new UnitConverter();

        // Take input from the user
        Console.Write("Enter the distance in kilometers: ");
        double km = Convert.ToDouble(Console.ReadLine());

        // Call the ConvertKmToMiles method and display the result
        double miles = unitConverter.ConvertKmToMiles(km);
        Console.WriteLine("Distance in miles: " + miles);
    }
}
