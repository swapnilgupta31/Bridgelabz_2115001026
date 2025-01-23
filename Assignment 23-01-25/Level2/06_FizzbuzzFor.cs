using System;

class FizzBuzz
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a positive integer
        Console.WriteLine("Enter a positive integer:");
        int number = int.Parse(Console.ReadLine());

        // Check if the input is a positive integer
        if (number <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }

        // Loop from 1 to the input number
        for (int i = 1; i <= number; i++)
        {
            // Check for multiples of 3 and 5
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            // Check for multiples of 3
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            // Check for multiples of 5
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            // Otherwise, print the number
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}
