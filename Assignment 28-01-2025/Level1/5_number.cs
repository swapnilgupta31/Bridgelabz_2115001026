using System ;
class Number {
    static int value(int number){
        if(number > 0){
            return 1;
        }
        else if ( number < 0 ){
            return -1;
        }
        else {
            return 0 ;
        }

    }
    public static void Main(string[] args){
        //take input of the number to be checked 
        Console.WriteLine("Enter a number");
        int number = int.Parse(Console.ReadLine());

        //call the method value 
        int result = value (number);
        //print the result 
        if ( result == 1){
        Console.WriteLine("The number is Positive.");
        }
        else if ( result == -1){
        Console.WriteLine("The number is Negative.");
        }
        else {

          Console.WriteLine("The number is Zero.");
        }
    }
}