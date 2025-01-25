using System;
class Sum{
    public static void Main (String[]args){
        //array of double data type having size 10 
        double []array = new double[10];

        //initialize the sum to 0.0 and index to 0 
        double sum = 0.0;
        int index = 0 ;

        //execute the while loop 
        
        while(true){
            Console.WriteLine("Enter the number : ");
            double number = double.Parse(Console.ReadLine());
        
        // check the negative 0 condition to terminate
        if (number <= 0 )
        {
            Console.WriteLine("Terminated.");
            break;
        }
        
        if( index >= 10){
            Console.WriteLine("End limit reached.");
            break;
        }

        array[index] = number;
        index++;

        }
        //calculate the sum of all stored numbers
        for ( int i = 0 ; i < index ; i++){
            sum += array[i];
        }
        //display the sum 
        Console.WriteLine("The sum of the numbers is : "+ sum);

    }
}