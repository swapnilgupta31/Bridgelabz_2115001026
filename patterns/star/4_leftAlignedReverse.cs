using System;
class Patterns{
    public static void Main(){
        int n = 5;
          for(int i = 1 ; i <= n ;i++){
            for(int j = 1 ; j <i ;j++){
                Console.Write("  ");
            }
            for(int k = i ; k<=n ;k++){
                Console.Write("* ");
            }
            Console.WriteLine();
        }

    }
}