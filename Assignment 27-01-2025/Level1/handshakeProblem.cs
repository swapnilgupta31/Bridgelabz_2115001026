using System;

class NumberOfHandshakes
{
    // Method to calculate number of handshakes
    static int Handshakes(int n)
    {
        return (n * (n - 1)) / 2;
    }

    static void Main(string[] args)
    {
        // Take the number of students as input
        Console.WriteLine("Enter the number of students:");
        int students = int.Parse(Console.ReadLine());

        // Call the method to calculate the handshakes and store the result
        int numberOfHandshakes = Handshakes(students);

        // Print the number of handshakes
        Console.WriteLine("The maximum number of handshakes for " + students + " students is " + numberOfHandshakes);
    }
}
