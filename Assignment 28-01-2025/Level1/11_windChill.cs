using System;
class WindChillSpeed
{
    public static double CalculateWindChill(double temperature, double windSpeed)
    {
        //wind chill formula
        double windChill = 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);
        return windChill;
    }
    static void Main(string[] args)
    {
        // Enter the temperature and wind speed
        Console.WriteLine("Enter the temperature (in Fahrenheit):");
        double temperature = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the wind speed (in mph):");
        double windSpeed = double.Parse(Console.ReadLine());

        // Call the method
        double result = CalculateWindChill(temperature, windSpeed);

        // Display the result
        Console.WriteLine("The wind chill will be: " + result);
    }
}
