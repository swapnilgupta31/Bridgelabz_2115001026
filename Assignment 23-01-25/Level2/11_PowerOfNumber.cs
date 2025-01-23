using System;

class PowerOfNumber
{
    static void Main(string[] args)
    {
        // Prompt the user to input the base number
        Console.WriteLine("Enter the base number:");
        int number = int.Parse(Console.ReadLine());

        // Prompt the user to input the power
        Console.WriteLine("Enter the power:");
        int power = int.Parse(Console.ReadLine());

        // Initialize the result variable to 1
        int result = 1;

        // Calculate the power using a for loop
        for (int i = 1; i <= power; i++)
        {
            result *= number; // Multiply result by the base number
        }

        // Display the result
        Console.WriteLine($"{number} raised to the power {power} is: {result}");
    }
}
