using System;

class GreatestFactor
{
    static void Main(string[] args)
    {
        // Prompt the user to input an integer
        Console.WriteLine("Enter a positive integer:");
        int number = int.Parse(Console.ReadLine());

        // Check if the input is a positive integer
        if (number <= 1)
        {
            Console.WriteLine("Please enter an integer greater than 1.");
            return;
        }

        // Initialize the greatest factor variable
        int greatestFactor = 1;

        // Loop from number - 1 down to 1
        for (int i = number - 1; i >= 1; i--)
        {
            // Check if the current number is a factor
            if (number % i == 0)
            {
                greatestFactor = i;
                break; // Exit the loop once the greatest factor is found
            }
        }

        // Display the greatest factor
        Console.WriteLine($"The greatest factor of {number} (besides itself) is: {greatestFactor}");
    }
}
