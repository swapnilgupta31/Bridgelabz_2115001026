using System;
class NaturalNumbersSum
{
    // Recursive method to calculate sum of n natural numbers
    public static int RecursiveSum(int n){
        if (n == 1)
            return 1;
        return n + RecursiveSum(n - 1);
    }
    // Method to calculate sum of n natural numbers using formula
    public static int FormulaSum(int n){
        return n * (n + 1) / 2;
    }
    static void Main(string[] args){
        // Take user input
        Console.WriteLine("Enter a natural number:");
        int number = int.Parse(Console.ReadLine());

        // Check if input is a natural number
        if (number <= 0){
            Console.WriteLine("Please enter a natural number greater than 0.");
            return;
        }
        // Calculate sum using recursion and formula
        int recursiveResult = RecursiveSum(number);
        int formulaResult = FormulaSum(number);

        // Display results
        Console.WriteLine("Sum using recursion: " + recursiveResult);
        Console.WriteLine("Sum using formula: " + formulaResult);

        // Compare results
        if (recursiveResult == formulaResult)
            Console.WriteLine("Both methods give the same result.");
        else
            Console.WriteLine("The results do not match.");
    }
}
