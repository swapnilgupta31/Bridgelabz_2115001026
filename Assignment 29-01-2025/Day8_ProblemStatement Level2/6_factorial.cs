using System;
class FactorialCalculator{
    static void Main(){
        // Get the input number
        int number = GetInput();

        // Calculate the factorial using recursion
        long factorial = CalculateFactorial(number);

        // Display the result
        DisplayResult(factorial);
    }

    // Function to get user input
    static int GetInput()
    {
        Console.Write("Enter a number: ");
        return int.Parse(Console.ReadLine());
    }

    // Function to calculate factorial using recursion
    static long CalculateFactorial(int n)
    {
        if (n == 0)  // Base case: factorial of 0 is 1
            return 1;
        else
            return n * CalculateFactorial(n - 1);  // Recursive case
    }

    // Function to display the result
    static void DisplayResult(long factorial)
    {
        Console.WriteLine("The factorial is: " + factorial);
    }
}
