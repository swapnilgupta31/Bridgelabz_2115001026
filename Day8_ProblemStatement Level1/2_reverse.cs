using System ;
class reverseString{
    static void Main (string[] args){
        //take input string
        Console.WriteLine("Enter the string :");
        string input = Console.ReadLine();

        //store the string in reverse order
        string output = "";
        for ( int i = input.Length -1 ; i >= 0 ; i--){
            output += input[i];
        }

        //print the output string .
        Console.WriteLine("Reversed string for "+ input+ " string is "+output );
    }
}