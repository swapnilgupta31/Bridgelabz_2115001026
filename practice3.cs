// File: CalculatorLibrary.cs
namespace CalculatorLibrary {
    public class Calculator {
        public int Multiply(int a, int b) {
            return a * b;
        }
    }
}


// File: Program.cs
using System;
using CalculatorLibrary; // Reference to the DLL

class Program {
    static void Main() {
        Calculator calc = new Calculator();
        Console.WriteLine("Multiplication Result: " + calc.Multiply(4, 5));
    }
}
