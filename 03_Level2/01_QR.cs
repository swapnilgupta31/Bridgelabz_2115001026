using System;

public class QuotientAndRemainder
{
    // Entry point of the program
    public static void Main(string[] args)
    {
        // Take two numbers as input
        Console.WriteLine("Enter the first number:");
        int number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int number2 = int.Parse(Console.ReadLine());

        // Calculate quotient and remainder
        int quotient = number1 / number2;
        int remainder = number1 % number2;

        // Print the result
        Console.WriteLine("The Quotient is " + quotient + " and Remainder is " + remainder + 
                          " of two numbers " + number1 + " and " + number2);
    }
}
