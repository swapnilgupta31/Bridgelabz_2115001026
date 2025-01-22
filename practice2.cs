using System;

class MathUtility {
    public static double Add(double a, double b) {
        return a + b;
    }

    public static double Subtract(double a, double b) {
        return a - b;
    }
}

class Program {
    static void Main() {
        Console.WriteLine("Addition: " + MathUtility.Add(5.5, 3.3));
        Console.WriteLine("Subtraction: " + MathUtility.Subtract(10.1, 4.4));
    }
}
