using System;

public class SwapNumbers
{
    // Entry point of the program
    public static void Main(string[] args)
    {
        // Take first number as input
        Console.WriteLine("Enter the first number:");
        int number1 = int.Parse(Console.ReadLine());

        // Take second number as input
        Console.WriteLine("Enter the second number:");
        int number2 = int.Parse(Console.ReadLine());

        // Swap the numbers
        int temp = number1;
        number1 = number2;
        number2 = temp;

        // Output the swapped numbers using string concatenation
        Console.WriteLine("The swapped numbers are " + number1 + " and " + number2);
    }
}
