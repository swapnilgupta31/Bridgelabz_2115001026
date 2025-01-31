using System;
class MaxOfThreeNumbers
{
    static void Main(string[] args){
        // Step 1: Get three numbers from the user
        int num1 = GetInput("Enter the first number: ");
        int num2 = GetInput("Enter the second number: ");
        int num3 = GetInput("Enter the third number: ");
        
        // Step 2: Find and display the maximum number
        int max = FindMax(num1, num2, num3);
        Console.WriteLine("The maximum number is: " + max);
    }

    // Function to take an integer input from the user
    static int GetInput(string prompt){
        Console.WriteLine(prompt);
        return Convert.ToInt32(Console.ReadLine());
    }

    // Function to find the maximum of three numbers
    static int FindMax(int a, int b, int c){
        int max = a; // Assume the first number is the largest initially
        if (b > max){
            max = b; // If second number is greater, update max
        }
        if (c > max){
            max = c; // If third number is greater, update max
        }
        return max; // Return the maximum number
    }
}
