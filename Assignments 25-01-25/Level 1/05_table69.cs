using System;
class table{
public static void Main(String[] args){

    //enter the number whose table to be printed .
    Console.WriteLine("Enter the number :");
    int number = int.Parse(Console.ReadLine());

    //declare an array table to store the table of number 
    int[] table = new int[10];

    //execute the for loop to store the in array table . 
    for ( int i = 5 ; i < 9 ; i++){
        table[i] = number*(i+1);
    } 
    
    //execute the loop to print the table. 
    for ( int i = 5 ; i < 9 ; i++){
        Console.WriteLine( number + " * " + (i+1) +" = " + table[i]);
    }
    }
}