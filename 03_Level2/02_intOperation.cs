using System;

public class IntOperation
{
    // Entry point of the program
    public static void Main(string[] args)
    {
        // Take three numbers a, b, and c as input
        Console.WriteLine("Enter the value for a:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the value for b:");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the value for c:");
        int c = int.Parse(Console.ReadLine());

        // Perform integer operations considering operator precedence
        int result1 = a + b * c; // First operation: a + (b * c)
        int result2 = a * b + c; // Second operation: (a * b) + c
        int result3 = c + a / b; // Third operation: c + (a / b)
        int result4 = a % b + c; // Fourth operation: (a % b) + c

        // Print the results of the operations
        Console.WriteLine("The results of Int Operations are " + result1 + ", " + result2 + ", " + result3 + ", and " + result4);
    }
}
