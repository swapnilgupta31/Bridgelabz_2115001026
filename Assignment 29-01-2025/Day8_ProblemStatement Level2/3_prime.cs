using System;
class PrimeNumberChecker{
    static void Main(string[] args)
    {
        // Step 1: Get the number from the user
        int number = GetInput("Enter a number to check if it's prime: ");
        
        // Step 2: Check if the number is prime
        bool isPrime = IsPrime(number);
        
        // Step 3: Display the result
        if (isPrime){
            Console.WriteLine(number + " is a prime number.");
        }
        else{
            Console.WriteLine(number + " is not a prime number.");
        }
    }

    // Function to take an integer input from the user
    static int GetInput(string prompt){
        Console.WriteLine(prompt);
        return Convert.ToInt32(Console.ReadLine());
    }

    // Function to check if a number is prime
    static bool IsPrime(int num)
    {
        if (num <= 1){
            return false; // Numbers less than or equal to 1 are not prime
        }

        // Check divisibility from 2 to num / 2
        for (int i = 2; i <= num / 2; i++){
            if (num % i == 0){
                return false; // If divisible by any number between 2 and num / 2, it's not prime
            }
        }
        return true; // If no divisors are found, the number is prime
    }
}
