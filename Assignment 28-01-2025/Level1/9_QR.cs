using System;
class QuotientRemainder{
    public static int[] FindRemainderAndQuotient(int number, int divisor){ 
    int quotient = number / divisor ;
    int remaninder = number % divisor ;

    return new int[] {quotient, remaninder};
}
    static void Main(string[] args){
        //take inputs 
        Console.WriteLine("Enter the number:");
        int number = int.Parse(Console.ReadLine());

        
        Console.WriteLine("Enter the Divisor:");
        int divisor = int.Parse(Console.ReadLine());

        int[] result = FindRemainderAndQuotient(number , divisor);
        Console.WriteLine("Quotient : "+ result[0] +"\nRemainder : " + result[1]);
    }
}
