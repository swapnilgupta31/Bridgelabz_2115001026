using System;
class AlphabetPattern {
    static void Main(string[] args) {
        int n = 5;
        int num = 65; // ASCII value of 'A'

        for (int i = 1; i <= n; i++) {
            for (int j = 1; j <= i; j++) {
                Console.Write((char)(num) + " "); // Print current character
                num++; // Increment to the next character
            }
            Console.WriteLine();
        }
    }
}
