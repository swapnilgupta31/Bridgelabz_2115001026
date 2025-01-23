using System;

class RocketLaunch
{
    static void Main(string[] args)
    {
        // Prompt the user for the countdown starting value
        Console.WriteLine("Enter the starting value for the countdown:");

        // Take user input for the counter
        int counter = int.Parse(Console.ReadLine());

        // Use while loop to count down to 1
        while (counter >= 1)
        {
            Console.WriteLine(counter);
            counter--; // Decrement the counter
        }

        // Print launch message
        Console.WriteLine("Liftoff!");
    }
}
