using System;
using System.Diagnostics;

class FibonacciComparison {
    static void Main() {
        int n = 30; // Change this value to test performance

        Stopwatch stopwatch = new Stopwatch();

        // Recursive Fibonacci (O(2^N))
        stopwatch.Start();
        int recursiveResult = FibonacciRecursive(n);
        stopwatch.Stop();
        Console.WriteLine("Recursive Fibonacci Result: " + recursiveResult);
        Console.WriteLine("Recursive Time: " + stopwatch.ElapsedMilliseconds + " ms");

        // Iterative Fibonacci (O(N))
        stopwatch.Restart();
        int iterativeResult = FibonacciIterative(n);
        stopwatch.Stop();
        Console.WriteLine("Iterative Fibonacci Result: " + iterativeResult);
        Console.WriteLine("Iterative Time: " + stopwatch.ElapsedMilliseconds + " ms");
    }

    static int FibonacciRecursive(int n) {
        if (n <= 1) return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    static int FibonacciIterative(int n) {
        if (n <= 1) return n;
        int a = 0, b = 1, sum;
        for (int i = 2; i <= n; i++) {
            sum = a + b;
            a = b;
            b = sum;
        }
        return b;
    }
}
