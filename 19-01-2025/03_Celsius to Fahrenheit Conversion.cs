using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the temperature in Celsius:");
        double celsius = double.Parse(Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine("The temperature in Fahrenheit is: " + fahrenheit);
    }
}
