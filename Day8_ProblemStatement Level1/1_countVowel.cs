using System;
class countVowels{
    static void Main(string[] args){
        Console.WriteLine("Enter the string: ");
        string input = Console.ReadLine().ToLower();

        int vowels = 0; 
        int consonants = 0;
        
        for( int i = 0 ; i < input.Length ;i++){
            if (input[i] == 'a' || input [i] == 'e'|| input [i] == 'i' || input [i] == 'o' || input [i] == 'u'  ){
                vowels++;
            }
            else{
                consonants++;
            }
        }

        Console.WriteLine("Vowels: " + vowels);
        Console.WriteLine("Consonants: " + consonants);
    }
}
