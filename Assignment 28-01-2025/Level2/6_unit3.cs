using System;
class UnitConverter{
    // Method to convert Fahrenheit to Celsius
    public static double ConvertFahrenheitToCelsius(double fahrenheit){
        return (fahrenheit - 32) * 5 / 9;
    }
    // Method to convert Celsius to Fahrenheit
    public static double ConvertCelsiusToFahrenheit(double celsius){
        return (celsius * 9 / 5) + 32;
    }
    // Method to convert pounds to kilograms
    public static double ConvertPoundsToKilograms(double pounds){
        double pounds2kilograms = 0.453592;
        return pounds * pounds2kilograms;
    }
    // Method to convert kilograms to pounds
    public static double ConvertKilogramsToPounds(double kilograms){
        double kilograms2pounds = 2.20462;
        return kilograms * kilograms2pounds;
    }
    // Method to convert gallons to liters
    public static double ConvertGallonsToLiters(double gallons){
        double gallons2liters = 3.78541;
        return gallons * gallons2liters;
    }
    // Method to convert liters to gallons
    public static double ConvertLitersToGallons(double liters){
        double liters2gallons = 0.264172;
        return liters * liters2gallons;
    }
    static void Main(string[] args){
        // Test the conversion methods
        Console.WriteLine("Convert Fahrenheit to Celsius:");
        Console.Write("Enter Fahrenheit: ");
        double fahrenheit = double.Parse(Console.ReadLine());
        Console.WriteLine(fahrenheit + " Fahrenheit = " + ConvertFahrenheitToCelsius(fahrenheit) + " Celsius");

        Console.WriteLine("\nConvert Celsius to Fahrenheit:");
        Console.Write("Enter Celsius: ");
        double celsius = double.Parse(Console.ReadLine());
        Console.WriteLine(celsius + " Celsius = " + ConvertCelsiusToFahrenheit(celsius) + " Fahrenheit");

        Console.WriteLine("\nConvert Pounds to Kilograms:");
        Console.Write("Enter pounds: ");
        double pounds = double.Parse(Console.ReadLine());
        Console.WriteLine(pounds + " pounds = " + ConvertPoundsToKilograms(pounds) + " kilograms");

        Console.WriteLine("\nConvert Kilograms to Pounds:");
        Console.Write("Enter kilograms: ");
        double kilograms = double.Parse(Console.ReadLine());
        Console.WriteLine(kilograms + " kilograms = " + ConvertKilogramsToPounds(kilograms) + " pounds");

        Console.WriteLine("\nConvert Gallons to Liters:");
        Console.Write("Enter gallons: ");
        double gallons = double.Parse(Console.ReadLine());
        Console.WriteLine(gallons + " gallons = " + ConvertGallonsToLiters(gallons) + " liters");

        Console.WriteLine("\nConvert Liters to Gallons:");
        Console.Write("Enter liters: ");
        double liters = double.Parse(Console.ReadLine());
        Console.WriteLine(liters + " liters = " + ConvertLitersToGallons(liters) + " gallons");
    }
}
