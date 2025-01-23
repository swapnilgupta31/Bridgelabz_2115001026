using System;

class SumOfNumbers
{
    static void Main(string[] args)
    {
        // Initialize the total to 0.0
        double total = 0.0;
        
        // Declare a variable to store the user input
        double userInput;

        // Use while loop to continue until user enters 0
        do
        {
            // Prompt the user to enter a number
            Console.WriteLine("Enter a number (enter 0 to stop):");

            // Get user input
            userInput = double.Parse(Console.ReadLine());

            // If the user enters a non-zero number, add it to total
            if (userInput != 0)
            {
                total += userInput;
            }

        } while (userInput != 0); // Loop until the user enters 0

        // Display the total value
        Console.WriteLine("Total sum: " + total);
    }
}
