using System;

class RocketLaunch
{
    static void Main(string[] args)
    {
        // Prompt the user for the countdown starting value
        Console.WriteLine("Enter the starting value for the countdown:");

        // Take user input for the counter
        int counter = int.Parse(Console.ReadLine());

        // Use for loop to count down to 1
        for (int i = counter; i >= 1; i--)
        {
            Console.WriteLine(i);
        }

        // Print launch message
        Console.WriteLine("Liftoff!");
    }
}
