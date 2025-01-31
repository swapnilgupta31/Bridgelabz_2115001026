using System;
class Review{
    // static void Main(string[] args){
    //     string str = Console.ReadLine();
    //     bool found = false; // Flag to track if a vowel is found

    //     for (int i = 0; i < str.Length; i++){
    //         switch(str[i]){
    //             case 'a': case 'e': case 'i': case 'o': case 'u': 
    //                 Console.WriteLine("The first vowel is " + str[i] + " .");
    //                 found = true;
    //                 break;
    //         }
    //         if (found) break; // Exit loop when a vowel is found
    //     }

    //     if (!found) Console.WriteLine("There is no vowel in the string .");
    // }
    static int flagValue(string str){
        int flag = 0 ;
        for(int i = 0 ; i < str.Length ; i++){
            if(str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u'){
                flag = 1 ;
                break;
            }
        }
        return flag;
    }
    static string vowel(string str){
        string vow = "";
        for(int i = 0 ; i < str.Length ; i++){
            if(str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' ){
                vow += str[i];
                break;
            }
        }
        return vow;
    }
    static void Main(string[] args){
        string str = Console.ReadLine();
        int flag = flagValue(str);
        string vow = vowel(str);
        switch(flag){
            case 0:
            Console.WriteLine("No  vowel");
            break;
            case 1:
            Console.WriteLine("The first vowel is " + vow + " .");
            break;
        }
    }
}
