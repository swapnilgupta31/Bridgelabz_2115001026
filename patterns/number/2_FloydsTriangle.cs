using System;
class NumberPattern{
    static void Main(String[] args) {
        int n = 5;
        int num= 1;
        for(int i = 1; i <= n; i++){
            for(int j = 1; j <= i; j++){
                Console.Write(num + " ");
                num++;
            }
            Console.WriteLine();
        }

    }
}