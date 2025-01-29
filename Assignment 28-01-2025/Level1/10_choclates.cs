using System;
class ChoclateDistribution{
    public static int[] choclates(int number, int children){ 
    int choclates = number / children ;
    int remaining = number % children ;

    return new int[] {choclates, remaining};
}
    static void Main(string[] args){
        //take inputs 
        Console.WriteLine("Enter the number of choclates :");
        int number = int.Parse(Console.ReadLine());

        
        Console.WriteLine("Enter the number of children :");
        int children = int.Parse(Console.ReadLine());

        int[] result = choclates(number , children);
        Console.WriteLine("Number of choclates to each student is : "+ result[0] +"\nThe remaining choclates will be  : " + result[1]);
    }
}
