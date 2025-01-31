using System;
class BasicCalculator
{
    static void Main()
    {
        // Get the numbers from the user
        Console.WriteLine("Enter the first number:");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double num2 = double.Parse(Console.ReadLine());

        // Get the operation choice from the user
        Console.WriteLine("Choose an operation: (+, -, *, /)");
        string operation = Console.ReadLine();

        // Perform the operation based on user input
        if (operation == "+")
        {
            double result = Add(num1, num2);
            Console.WriteLine("Result: " + result);
        }
        else if (operation == "-")
        {
            double result = Subtract(num1, num2);
            Console.WriteLine("Result: " + result);
        }
        else if (operation == "*")
        {
            double result = Multiply(num1, num2);
            Console.WriteLine("Result: " + result);
        }
        else if (operation == "/")
        {
            if (num2 != 0)
            {
                double result = Divide(num1, num2);
                Console.WriteLine("Result: " + result);
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
            }
        }
        else
        {
            Console.WriteLine("Invalid operation.");
        }
    }

    // Function to add two numbers
    static double Add(double a, double b)
    {
        return a + b;
    }

    // Function to subtract two numbers
    static double Subtract(double a, double b)
    {
        return a - b;
    }

    // Function to multiply two numbers
    static double Multiply(double a, double b)
    {
        return a * b;
    }

    // Function to divide two numbers
    static double Divide(double a, double b)
    {
        return a / b;
    }
}
