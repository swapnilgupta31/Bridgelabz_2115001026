using System;
class FibonacciGenerator
{
    static void Main(string[] args){
        // Step 1: Get the number of terms from the user
        int terms = GetInput("Enter the number of terms for Fibonacci sequence: ");
        
        // Step 2: Generate and print the Fibonacci sequence
        GenerateFibonacci(terms);
    }
    // Function to take integer input from the user
    static int GetInput(string prompt){
        Console.WriteLine(prompt);
        return Convert.ToInt32(Console.ReadLine());
    }
    // Function to generate and print the Fibonacci sequence
    static void GenerateFibonacci(int n){
        int firstTerm = 0, secondTerm = 1, nextTerm;

        Console.WriteLine("Fibonacci Sequence up to " + n + " terms:");

        for (int i = 1; i <= n; i++){
            if (i == 1){
                Console.Write(firstTerm + " ");
                continue;
            }
            if (i == 2){
                Console.Write(secondTerm + " ");
                continue;
            }
            
            // Calculate the next term
            nextTerm = firstTerm + secondTerm;
            Console.Write(nextTerm + " ");
            
            // Update the terms for the next iteration
            firstTerm = secondTerm;
            secondTerm = nextTerm;
        }
        Console.WriteLine(); // For a new line after the sequence is printed
    }
}
