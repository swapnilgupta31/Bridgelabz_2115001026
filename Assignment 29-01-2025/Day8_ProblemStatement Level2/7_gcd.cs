using System;

class GCD_LCM_Calculator
{
    static void Main()
    {
        // Get the two numbers from the user
        int num1 = GetInput("Enter the first number: ");
        int num2 = GetInput("Enter the second number: ");

        // Calculate GCD and LCM
        int gcd = CalculateGCD(num1, num2);
        int lcm = CalculateLCM(num1, num2, gcd);

        // Display the results
        Console.WriteLine("The GCD of " + num1 + " and " + num2 + " is: " + gcd);
        Console.WriteLine("The LCM of " + num1 + " and " + num2 + " is: " + lcm);
    }

    // Function to get user input
    static int GetInput(string message)
    {
        Console.Write(message);
        return int.Parse(Console.ReadLine());
    }

    // Function to calculate GCD (Greatest Common Divisor) using Euclidean algorithm
    static int CalculateGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Function to calculate LCM (Least Common Multiple)
    static int CalculateLCM(int a, int b, int gcd)
    {
        return (a * b) / gcd;  // Formula: LCM(a, b) = (a * b) / GCD(a, b)
    }
}
