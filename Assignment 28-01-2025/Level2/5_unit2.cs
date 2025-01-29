using System;
class UnitConverter{
    // Method to convert yards to feet
    public static double ConvertYardsToFeet(double yards){
        double yards2feet = 3;
        return yards * yards2feet;
    }
    // Method to convert feet to yards
    public static double ConvertFeetToYards(double feet){
        double feet2yards = 0.333333;
        return feet * feet2yards;
    }
    // Method to convert meters to inches
    public static double ConvertMetersToInches(double meters){
        double meters2inches = 39.3701;
        return meters * meters2inches;
    }
    // Method to convert inches to meters
    public static double ConvertInchesToMeters(double inches){
        double inches2meters = 0.0254;
        return inches * inches2meters;
    }
    // Method to convert inches to centimeters
    public static double ConvertInchesToCentimeters(double inches){
        double inches2cm = 2.54;
        return inches * inches2cm;
    }
    static void Main(string[] args){
        // Test the conversion methods
        Console.WriteLine("Convert Yards to Feet:");
        Console.Write("Enter yards: ");
        double yards = double.Parse(Console.ReadLine());
        Console.WriteLine(yards + " yards = " + ConvertYardsToFeet(yards) + " feet");

        Console.WriteLine("\nConvert Feet to Yards:");
        Console.Write("Enter feet: ");
        double feet = double.Parse(Console.ReadLine());
        Console.WriteLine(feet + " feet = " + ConvertFeetToYards(feet) + " yards");

        Console.WriteLine("\nConvert Meters to Inches:");
        Console.Write("Enter meters: ");
        double meters = double.Parse(Console.ReadLine());
        Console.WriteLine(meters + " meters = " + ConvertMetersToInches(meters) + " inches");

        Console.WriteLine("\nConvert Inches to Meters:");
        Console.Write("Enter inches: ");
        double inches = double.Parse(Console.ReadLine());
        Console.WriteLine(inches + " inches = " + ConvertInchesToMeters(inches) + " meters");

        Console.WriteLine("\nConvert Inches to Centimeters:");
        Console.Write("Enter inches: ");
        double inchesToCm = double.Parse(Console.ReadLine());
        Console.WriteLine(inchesToCm + " inches = " + ConvertInchesToCentimeters(inchesToCm) + " centimeters");
    }
}
