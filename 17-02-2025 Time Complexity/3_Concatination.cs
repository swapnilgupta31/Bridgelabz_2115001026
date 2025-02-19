using System;
using System.Diagnostics;
using System.Text;

class StringConcatenationTest {
    static void Main() {
        int count = 100000; // Adjust for testing
        string sampleText = "Hello";

        Stopwatch stopwatch = new Stopwatch();

        // Using string (Inefficient)
        stopwatch.Start();
        string result = "";
        for (int i = 0; i < count; i++) {
            result += sampleText;
        }
        stopwatch.Stop();
        Console.WriteLine("String Concatenation Time: " + stopwatch.ElapsedMilliseconds + " ms");

        // Using StringBuilder (Efficient)
        stopwatch.Restart();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < count; i++) {
            sb.Append(sampleText);
        }
        stopwatch.Stop();
        Console.WriteLine("StringBuilder Concatenation Time: " + stopwatch.ElapsedMilliseconds + " ms");
    }
}
