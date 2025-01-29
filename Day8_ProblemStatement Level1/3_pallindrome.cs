using System ;
class reverseString{
    static void Main (string[] args){
        //take input string 
        Console.WriteLine("Enter the string :");
        string input = Console.ReadLine();

        //declare the two pointers start and end . 
        int start = 0 ; 
        int end = input.Length -1 ;
        int flag = 0 ;

        while(start<=end){
            //comapre the first and last index 
            if (input[start++] != input[end--]){
                flag = -1;
                break;
        }
        }
        if (flag == -1)
        Console.WriteLine("Not a pallindrome .");

        else 
        Console.WriteLine("Pallindrome .");
    }
}