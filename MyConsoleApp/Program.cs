using System;

class Calculator
{
    // Method for Addition
    public double Add(double a, double b)
    {
        return a + b;
    }

    // Method for Subtraction
    public double Subtract(double a, double b)
    {
        return a - b;
    }

    // Method for Multiplication
    public double Multiply(double a, double b)
    {
        return a * b;
    }

    // Method for Division
    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return double.NaN; // Return 'Not a Number' if division by zero
        }
        return a / b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();

        Console.WriteLine("Welcome to the Calculator App!");
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Choose an operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.Write("Enter your choice (1-4): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        double result = 0;

        switch (choice)
        {
            case 1:
                result = calc.Add(num1, num2);
                Console.WriteLine($"Result: {result}");
                break;
            case 2:
                result = calc.Subtract(num1, num2);
                Console.WriteLine($"Result: {result}");
                break;
            case 3:
                result = calc.Multiply(num1, num2);
                Console.WriteLine($"Result: {result}");
                break;
            case 4:
                result = calc.Divide(num1, num2);
                if (!double.IsNaN(result))
                {
                    Console.WriteLine($"Result: {result}");
                }
                break;
            default:
                Console.WriteLine("Invalid choice! Please select a valid option.");
                break;
        }

        Console.WriteLine("Thank you for using the Calculator App!");
    }
}
