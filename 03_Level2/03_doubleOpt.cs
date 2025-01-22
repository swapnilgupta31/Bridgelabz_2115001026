using System;

public class DoubleOpt
{
    // Entry point of the program
    public static void Main(string[] args)
    {
        // Take three double values a, b, and c as input
        Console.WriteLine("Enter the value for a:");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the value for b:");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the value for c:");
        double c = double.Parse(Console.ReadLine());

        // Perform double operations considering operator precedence
        double result1 = a + b * c; // First operation: a + (b * c)
        double result2 = a * b + c; // Second operation: (a * b) + c
        double result3 = c + a / b; // Third operation: c + (a / b)
        double result4 = a % b + c; // Fourth operation: (a % b) + c

        // Print the results of the operations
        Console.WriteLine("The results of Double Operations are " + result1 + ", " + result2 + ", " + result3 + ", and " + result4);
    }
}
