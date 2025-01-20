using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the distance in kilometers:");
        double kilometers = double.Parse(Console.ReadLine());

        double miles = kilometers * 0.621371;
        Console.WriteLine("The distance in miles is: " + miles);
    }
}
