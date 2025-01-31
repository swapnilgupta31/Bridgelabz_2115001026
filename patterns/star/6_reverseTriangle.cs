using System;
class Pattern {
    public static void Main(string[] args) {
        int n = 5;
        for (int i = 1; i <= n; i++) {
            for (int j = 1; j < i; j++) { 
                Console.Write(" "); // Printing spaces
            }
            for (int k = i; k <= n; k++) {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}
