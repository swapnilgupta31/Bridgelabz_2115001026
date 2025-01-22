using System;

public class BasicCalculator
{
    // Entry point of the program
    public static void Main(string[] args)
    {
        // Take two floating-point numbers as input
        Console.WriteLine("Enter the first number: ");
        double number1 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the second number: ");
        double number2 = double.Parse(Console.ReadLine());
        
        // Perform arithmetic operations
        double addition = number1 + number2;
        double subtraction = number1 - number2;
        double multiplication = number1 * number2;
        double division = number1 / number2;

        // Print the results using string concatenation
        Console.WriteLine("The addition, subtraction, multiplication and division value of 2 numbers " 
                          + number1 + " and " + number2 
                          + " is " + addition + ", " 
                          + subtraction + ", " 
                          + multiplication + ", and " 
                          + division);
    }
}
