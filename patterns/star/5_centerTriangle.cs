using System;
class Pattern{
    public static void Main(string[] args) {
        int n = 5;
        for (int i = 1; i <= n; i++){
            for ( int j = i ; j < n ;j++){
                Console.Write(" ");
            }
            for ( int k = 1 ; k <= i ;k++){
                Console.Write("* ");
            }
            Console.WriteLine();
        }
}
}