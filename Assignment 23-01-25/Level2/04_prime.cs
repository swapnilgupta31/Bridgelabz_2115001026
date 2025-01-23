using System;

class PrimeNumberChecker
{
    static void Main(string[] args)
    {
        // Prompt the user for input
        Console.WriteLine("Enter a number to check if it is a prime number:");
        int number = int.Parse(Console.ReadLine());

        // Prime numbers are greater than 1
        if (number <= 1)
        {
            Console.WriteLine(number + " is not a prime number.");
            return;
        }

        // Boolean variable to track if the number is prime
        bool isPrime = true;

        // Loop from 2 to the square root of the number (for efficiency)
        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
            {
                isPrime = false; // Found a divisor, so not prime
                break;
            }
        }

        // Output the result
        if (isPrime)
        {
            Console.WriteLine(number + " is a prime number.");
        }
        else
        {
            Console.WriteLine(number + " is not a prime number.");
        }
    }
}
