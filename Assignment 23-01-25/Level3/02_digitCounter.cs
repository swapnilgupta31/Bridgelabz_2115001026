using System;

class DigitCounter
{
    static void Main(string[] args)
    {
        // Prompt the user to input an integer
        Console.WriteLine("Enter an integer:");
        int number = int.Parse(Console.ReadLine());

        // Handle the case for zero explicitly
        if (number == 0)
        {
            Console.WriteLine("The number of digits in 0 is 1.");
            return;
        }

        // Initialize variables
        int count = 0;
        int originalNumber = Math.Abs(number); // Use the absolute value to handle negative numbers

        // Count the digits
        while (originalNumber != 0)
        {
            originalNumber /= 10; // Remove the last digit
            count++;              // Increment the count
        }

        // Display the result
        Console.WriteLine($"The number of digits in {number} is {count}.");
    }
}
