using System;

class FactorialCalculator
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a positive integer
        Console.WriteLine("Enter a positive integer:");

        // Get the user input
        int number = int.Parse(Console.ReadLine());

        // Check if the input is a positive integer
        if (number < 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }

        // Initialize the factorial variable
        int factorial = 1;

        // Compute the factorial using a for loop
        for (int i = 1; i <= number; i++)
        {
            factorial *= i; // Multiply factorial by i
        }

        // Print the result
        Console.WriteLine("The factorial of " + number + " is: " + factorial);
    }
}
