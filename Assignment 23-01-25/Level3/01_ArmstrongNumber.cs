using System;

class ArmstrongNumberCheck
{
    static void Main(string[] args)
    {
        // Prompt the user to input an integer
        Console.WriteLine("Enter a positive integer:");
        int number = int.Parse(Console.ReadLine());

        // Validate the input
        if (number <= 0)
        {
            Console.WriteLine("Please enter a positive integer greater than 0.");
            return;
        }

        // Initialize variables
        int originalNumber = number;
        int sum = 0;

        // Check if the number is an Armstrong number
        while (originalNumber != 0)
        {
            int digit = originalNumber % 10;      // Get the last digit
            sum += digit * digit * digit;         // Add the cube of the digit to the sum
            originalNumber /= 10;                 // Remove the last digit
        }

        // Compare the sum with the original number
        if (sum == number)
        {
            Console.WriteLine($"{number} is an Armstrong number.");
        }
        else
        {
            Console.WriteLine($"{number} is not an Armstrong number.");
        }
    }
}
