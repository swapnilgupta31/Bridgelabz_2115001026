using System;

class OddEvenNumbers
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a positive integer
        Console.WriteLine("Enter a positive integer:");

        // Get the user input
        int number = int.Parse(Console.ReadLine());

        // Check if the input is a natural number
        if (number < 1)
        {
            Console.WriteLine("Please enter a natural number (positive integer greater than 0).");
            return;
        }

        // Iterate from 1 to the user-entered number
        for (int i = 1; i <= number; i++)
        {
            // Check if the current number is odd or even
            if (i % 2 == 0)
            {
                Console.WriteLine(i + " is an even number.");
            }
            else
            {
                Console.WriteLine(i + " is an odd number.");
            }
        }
    }
}
