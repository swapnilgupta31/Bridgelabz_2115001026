using System;

class OperatorExamples
{
    static void Main(string[] args)
    {
        // Arithmetic Operators
        int a = 10, b = 5;
        Console.WriteLine("Addition: " + (a + b));
        Console.WriteLine("Subtraction: " + (a - b));
        Console.WriteLine("Multiplication: " + (a * b));
        Console.WriteLine("Division: " + (a / b));
        Console.WriteLine("Modulus: " + (a % b));

        // Relational Operators
        Console.WriteLine("Equal: " + (a == b));
        Console.WriteLine("Not Equal: " + (a != b));
        Console.WriteLine("Greater: " + (a > b));
        Console.WriteLine("Less: " + (a < b));

        // Logical Operators
        bool x = true, y = false;
        Console.WriteLine("AND: " + (x && y));
        Console.WriteLine("OR: " + (x || y));
        Console.WriteLine("NOT x: " + (!x));

        // Bitwise Operators
        int p = 6, q = 3; // 6 = 110, 3 = 011
        Console.WriteLine("Bitwise AND: " + (p & q)); // 010
        Console.WriteLine("Bitwise OR: " + (p | q));  // 111

        // Assignment Operators
        int z = 10;
        z += 5; // z = z + 5
        Console.WriteLine("Assignment (+=): " + z);

        // Unary Operators
        int num = 10;
        Console.WriteLine("Post-increment: " + (num++));
        Console.WriteLine("Pre-increment: " + (++num));

        // Ternary Operator
        int result = (a > b) ? a : b;
        Console.WriteLine("Ternary: The larger number is " + result);
    }
}
