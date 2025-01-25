using System ; 

class NumbersCheck{
    public static void Main (string[] args){
        
        //if the user want to give an array size
        int n = 5 ; // remove this
        //uncommemnt the below line of code 
        // int n = int.Parse(Console.ReadLine());
        
        //make the array of 5 elements 
        int [] array = new int [n];

        //intiate a for loop to take inputs for the array 
        Console.WriteLine("Enter the 5 numbers of the array :");
        for ( int i = 0 ; i < array.Length ; i++){
            array[i] = int.Parse(Console.ReadLine());
        }

        //run a for loop to traverse through the array 
        for ( int i = 0 ; i < array.Length ; i++){
            if (array[i] < 0 ){
                Console.WriteLine("The number "+ array[i]+ " Negative");
            }
            else if (array[i] == 0){
                Console.WriteLine("The number "+ array[i]+ " Zero");
            }
            else {
                if(array[i]%2==0){
                    Console.WriteLine("The number "+ array[i]+ " Even");
                }
                else{
                    Console.WriteLine("The number "+ array[i]+ " Odd");
                }
            }
        }

        // to check the first and the last element of the array .
        if(array[0] < array[ array.Length - 1 ]){
                Console.WriteLine("Last element is greater that last element.");
            }
            else if (array[0] > array[array.Length - 1]){
                Console.WriteLine("First Element is greater than last element.");
            }
            else{
                Console.WriteLine("First and Last elements are equal.");
            }
    }
}