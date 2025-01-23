using System;

class MultiplesOfNumber
{
    static void Main(string[] args)
    {
        // Prompt the user to input a number
        Console.WriteLine("Enter a positive integer:");
        int number = int.Parse(Console.ReadLine());

        // Validate the input
        if (number <= 0)
        {
            Console.WriteLine("Please enter a positive integer greater than 0.");
            return;
        }

        // Display the multiples of the number below 100
        Console.WriteLine($"Multiples of {number} below 100 are:");
        for (int i = 100; i >= 1; i--) // Loop from 100 down to 1
        {
            if (i % number == 0) // Check if i is a multiple of the number
            {
                Console.WriteLine(i); // Print the multiple
            }
        }
    }
}
