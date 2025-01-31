using System;
class AlphabetPattern{
    static void Main(string[] args){
        int n = 5;
        for (int i = 1; i <= n; i++){
            for (int j = 1; j <= i; j++){
                Console.Write((char)(64+j)+" "); //ASCII value of A is 65
            }
            Console.WriteLine();
        }

    }
}