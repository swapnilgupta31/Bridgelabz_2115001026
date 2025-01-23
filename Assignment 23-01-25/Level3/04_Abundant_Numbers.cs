using System;

class AbundantNumberCheck
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
        int sum = 0;

        // Find the sum of divisors
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0) // Check if 'i' is a divisor
            {
                sum += i; // Add the divisor to the sum
            }
        }

        // Check if the sum of divisors is greater than the number
        if (sum > number)
        {
            Console.WriteLine($"{number} is an Abundant Number.");
        }
        else
        {
            Console.WriteLine($"{number} is not an Abundant Number.");
        }
    }
}
