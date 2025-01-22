using System;

public class TemperatureConversion
{
    // Entry point of the program
    public static void Main(string[] args)
    {
        // Take temperature in Celsius as input
        Console.WriteLine("Enter the temperature in Celsius:");
        double celsius = double.Parse(Console.ReadLine());

        // Convert Celsius to Fahrenheit using the formula
        double fahrenheitResult = (celsius * 9 / 5) + 32;

        // Print the result of the conversion
        Console.WriteLine("The " + celsius + " Celsius is " + fahrenheitResult + " Fahrenheit");
    }
}
