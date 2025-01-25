using System;

class FizzBuzz
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a positive integer:");
        int number = int.Parse(Console.ReadLine());

        // Check if the number is positive
        if (number <= 0)
        {
            Console.WriteLine("Enter a positive integer.");
            return;
        }

        // Create a string array to store the results
        string[] results = new string[number + 1]; 

        // Loop from 1 to the entered number
        for (int i = 1; i <= number; i++)
        {
            // Check if the number is a multiple of 3, 5, or both
            if (i % 3 == 0 && i % 5 == 0)
            {
                results[i] = "FizzBuzz";
            }
            else if (i % 3 == 0)
            {
                results[i] = "Fizz";
            }
            else if (i % 5 == 0)
            {
                results[i] = "Buzz";
            }
            else
            {
                results[i] = i.ToString(); // Save the number itself
            }
        }

        // Display the results for each index position
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine("Position " + i + " = " + results[i]);
        }
    }
}
