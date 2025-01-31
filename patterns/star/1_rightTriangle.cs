using System;

class LeftTriangle {
    static void Main() {
        int n = 5; 
        for(int i = 1; i <= n; i++) {
            for(int j = 1; j <= i; j++) {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

        for(int i = 1 ; i <= n ;i++){
            for(int j = n ; j >=i ;j++){
                Console.Write("* ");
            }
            for(int k = 0 ; k<n ;k++){
                Console.Write("  ");
            }
            Console.WriteLine();
        }



    }
}
