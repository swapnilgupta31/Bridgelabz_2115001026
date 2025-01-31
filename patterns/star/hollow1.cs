using System;
class Hollow{
    static void Main(string []args){
        int n = 5;
        for(int i = 1 ; i <= n ; i++){
            for(int j= 1; j <= n ; j++){
                if(i == 1 || j == 1 || i == n || j == n ){
                    Console.Write("* ");
                }
                else{
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
    }
}