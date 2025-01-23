using System;

class FactorsOfNumber
{
    static void Main(string[] args)
    {
        // Prompt the user to input a number
        Console.WriteLine("Enter a positive integer:");
        int number = int.Parse(Console.ReadLine());

        // Check if the input is a valid positive integer
        if (number <= 0)
        {
            Console.WriteLine("Please enter a positive integer greater than 0.");
            return;
        }

        // Display the factors
        Console.WriteLine($"The factors of {number} are:");
        for (int i = 1; i <= number; i++) // Include the number itself as a factor
        {
            if (number % i == 0) // Check if i is a factor of the number
            {
                Console.WriteLine(i);
            }
        }
    }
}
