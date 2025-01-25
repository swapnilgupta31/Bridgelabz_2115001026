using System ;

class voteEligibe{
    public static void Main (string[] args){
        // take input the number of students . 
        Console.WriteLine("Enter the number of students :");
        int n = int.Parse(Console.ReadLine());

        //Define an array to store the age of n students . 
        // Console.WriteLine("Enter the ages of "+ n " students :");
        int [] ages = new int[n];

        // prompt the user to enter the ages of the students . 
        Console.WriteLine("Enter the ages of "+ n +" students :");
        
        //run loop over array to input ages in the array 
        for( int i = 0 ; i < n ; i++){
            Console.Write("Enter the age of Student " + (i+1) + ":");
            ages[i] = int.Parse(Console.ReadLine());
        }

        // loop thorough the array to check the student eligibility 
        for(int i = 0 ; i < ages.Length ; i++){

            //get the age of current student
            int age = ages[i];

            //check if negative age 
            if ( age < 0){
                Console.WriteLine("Invalid age : "+ age);
            }
            else if ( age >= 18 ){
                Console.WriteLine("The Student with the age " + age + " can vote.");
            }

            //if not eligible to vote 
            else{
                Console.WriteLine("The Student with the age "+ age + " can not vote.");
            }
        }
    }
}