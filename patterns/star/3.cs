using System;
class Patterns{
    static void Main(string[] args){
        int n = 5;
        for(int i = 1; i <= n; i++){ 
            for (int j = n; j > i; j--){ 
                Console.Write("  "); // Printing spaces
            }
            for(int k = 1; k <= i; k++){ 
                Console.Write("* "); // Printing stars
            }
            Console.WriteLine();
        }
    }
}
