using System;
class TemperatureConverter
{
    static void Main()
    {
        // Get the temperature input from the user
        Console.WriteLine("Enter temperature value:");
        double temperature = double.Parse(Console.ReadLine());

        // Get the conversion choice from the user
        Console.WriteLine("Enter 'C' to convert to Celsius or 'F' to convert to Fahrenheit:");
        string choice = Console.ReadLine().ToUpper();

        // Convert based on user choice
        if (choice == "C")
        {
            double celsius = FahrenheitToCelsius(temperature);
            Console.WriteLine(temperature + " Fahrenheit is " + celsius + " Celsius.");
        }
        else if (choice == "F")
        {
            double fahrenheit = CelsiusToFahrenheit(temperature);
            Console.WriteLine(temperature + " Celsius is " + fahrenheit + " Fahrenheit.");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please enter 'C' or 'F'.");
        }
    }

    // Function to convert Fahrenheit to Celsius
    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    // Function to convert Celsius to Fahrenheit
    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
}
