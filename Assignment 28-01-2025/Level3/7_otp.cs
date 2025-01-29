using System;

public class OTPGenerator{
    public static int GenerateOTP(){
        Random random = new Random();
        return random.Next(100000, 1000000); // Generate a 6-digit number
    }

    public static bool AreUnique(int[] otpArray){
        // Check if all elements in the array are unique
        for (int i = 0; i < otpArray.Length; i++){
            for (int j = i + 1; j < otpArray.Length; j++){
                if (otpArray[i] == otpArray[j]){
                    return false; // Found a duplicate
                }
            }
        }
        return true; // All OTPs are unique
    }

    public static void Main(string[] args){
        int[] otpArray = new int[10];

        // Generate OTPs 10 times and store them in the array
        for (int i = 0; i < 10; i++){
            otpArray[i] = GenerateOTP();
            Console.WriteLine("OTP " + (i + 1) + ": " + otpArray[i]);
        }

        // Validate if all OTPs are unique
        bool isUnique = AreUnique(otpArray);
        if (isUnique){
            Console.WriteLine("All OTPs are unique.");
        } else {
            Console.WriteLine("Some OTPs are not unique.");
        }
    }
}
