using System;
class SumOFNUmbers{
    static int sumOfNumbers(int number){
        int sum = 0;
        for ( int i = 1 ; i <= number ; i++){
            sum += i ;
        }
        return sum ;
    }
    static void Main(string[] args){
        //input the natural number
        Console.WriteLine("Enter the natural number (greater than 0) :");
        int number = int.Parse(Console.ReadLine());
        
        //call the static method and store in result .
        int result = sumOfNumbers(number);

        //print the result .
        Connsole.WriteLine("The sum of "+ number+ " Natural numbers is "+ result );

    }
}