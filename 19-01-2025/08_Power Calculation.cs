using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the base:");
        double baseNum = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the exponent:");
        double exponent = double.Parse(Console.ReadLine());

        double result = Math.Pow(baseNum, exponent);
        Console.WriteLine("The result is: " + result);
    }
}
