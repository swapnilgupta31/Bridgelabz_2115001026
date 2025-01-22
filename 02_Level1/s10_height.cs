using System;

public class HeightConverter
{
    // Entry point of the program
    public static void Main(string[] args)
    {
        // Take height in centimeters as input
        Console.WriteLine("Enter your height in centimeters: ");
        double heightCm = double.Parse(Console.ReadLine());

        // Convert height to inches (1 inch = 2.54 cm)
        double heightInches = heightCm / 2.54;

        // Convert inches to feet and remaining inches
        int feet = (int)(heightInches / 12); // Integer part is feet
        double remainingInches = heightInches % 12; // Remainder is inches

        // Print the result using string concatenation
        Console.WriteLine("Your height in cm is " + heightCm.ToString("F2") + 
                          ", while in feet is " + feet + 
                          " and inches is " + remainingInches.ToString("F2"));
    }
}
