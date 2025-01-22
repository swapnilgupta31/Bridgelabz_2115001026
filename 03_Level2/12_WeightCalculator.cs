using System;

public class WeightConverter
{
    // Entry point of the program
    public static void Main(string[] args)
    {
        // Take user input for weight in pounds
        Console.WriteLine("Enter the weight in pounds:");
        double weightInPounds = double.Parse(Console.ReadLine());
        
        // Convert pounds to kilograms
        double weightInKg = weightInPounds * 2.2;
        
        // Output the results using string concatenation
        Console.WriteLine("The weight of the person in pounds is " + weightInPounds + " and in kg is " + weightInKg);
    }
}
