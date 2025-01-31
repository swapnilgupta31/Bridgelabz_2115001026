using System;
class LeftTriangle {
    static void Main() {
        int rows = 5; 
        for(int i = 1; i <= rows; i++) {
            for(int j = 5; j >= i; j--) {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}
