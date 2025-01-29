using System;
class UnitConverter{
    // Method to convert kilometers to miles
    public static double ConvertKmToMiles(double km){
        double km2miles = 0.621371;
        return km * km2miles;
    }
    // Method to convert miles to kilometers
    public static double ConvertMilesToKm(double miles){
        double miles2km = 1.60934;
        return miles * miles2km;
    }
    // Method to convert meters to feet
    public static double ConvertMetersToFeet(double meters){
        double meters2feet = 3.28084;
        return meters * meters2feet;
    }
    // Method to convert feet to meters
    public static double ConvertFeetToMeters(double feet){
        double feet2meters = 0.3048;
        return feet * feet2meters;
    }
    static void Main(string[] args){
        // Test the conversion methods
        Console.WriteLine("Convert Kilometers to Miles:");
        Console.Write("Enter kilometers: ");
        double kilometers = double.Parse(Console.ReadLine());
        Console.WriteLine(kilometers + " km = " + ConvertKmToMiles(kilometers) + " miles");

        Console.WriteLine("\nConvert Miles to Kilometers:");
        Console.Write("Enter miles: ");
        double miles = double.Parse(Console.ReadLine());
        Console.WriteLine(miles + " miles = " + ConvertMilesToKm(miles) + " km");

        Console.WriteLine("\nConvert Meters to Feet:");
        Console.Write("Enter meters: ");
        double meters = double.Parse(Console.ReadLine());
        Console.WriteLine(meters + " meters = " + ConvertMetersToFeet(meters) + " feet");

        Console.WriteLine("\nConvert Feet to Meters:");
        Console.Write("Enter feet: ");
        double feet = double.Parse(Console.ReadLine());
        Console.WriteLine(feet + " feet = " + ConvertFeetToMeters(feet) + " meters");
    }
}
