using System;
class HollowPyramid {
    static void Main(string[] args) {
        int n = 5; // Number of rows

        for (int i = 1; i <= n; i++) { // Controls the number of rows
            
            // Printing leading spaces for alignment
            for (int j = i; j < n; j++) {
                Console.Write(" ");
            }

            // Printing the stars and spaces inside the pyramid
            for (int k = 1; k <= (2 * i - 1); k++) {
                if (k == 1 || k == (2 * i - 1) || i == n) 
                    Console.Write("*"); // Print '*' at the edges
                else
                    Console.Write(" "); // Print space inside
            }

            Console.WriteLine(); // Move to the next line
        }
    }
}
 