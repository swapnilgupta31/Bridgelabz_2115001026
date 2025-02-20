using System;
using System.IO;

class UserInputToFile {
    static void Main() {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        string age = Console.ReadLine();

        Console.Write("Enter your favorite programming language: ");
        string language = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter("userdata.txt")) {
            writer.WriteLine("Name: " + name);
            writer.WriteLine("Age: " + age);
            writer.WriteLine("Favorite Language: " + language);
        }

        Console.WriteLine("User data saved successfully.");
    }
}
