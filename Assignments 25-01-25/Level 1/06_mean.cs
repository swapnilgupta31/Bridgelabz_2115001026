using System;
class meanHeight{
    public static void Main(String[] args){
        //take number of students as input  here 11 
        Console.WriteLine("Enter the number of players:");
        int number = int.Parse(Console.ReadLine());

        //make an array to store height
        double[] heights = new double[number];

        //initialise the sum as 0 of the height /
        double sum = 0.0;

        //take height as input and sum them .
        Console.WriteLine("Enter the heights of the students (in cm):");
        for ( int i = 0 ; i < number ; i++){
            heights[i] = double.Parse(Console.ReadLine());
            sum += heights[i];
        }
        //calculate mean 
        double mean = sum / number ; 
        Console.Write("Mean height of the players is : "+ mean + " cm");
    }
}