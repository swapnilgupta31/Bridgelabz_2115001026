using System;

class SumOfNumbers
{
    static void Main(string[] args)
    {
        // Initialize the total to 0.0
        double total = 0.0;

        while (true) // Infinite loop
        {
            // Prompt the user to enter a number
            Console.WriteLine("Enter a number (enter 0 or a negative number to stop):");

            // Get user input
            double userInput = double.Parse(Console.ReadLine());

            // Check if the user entered 0 or a negative number
            if (userInput <= 0)
            {
                break; // Exit the loop
            }

            // Add the user-entered value to the total
            total += userInput;
        }

        // Display the total value
        Console.WriteLine("Total sum: " + total);
    }
}
