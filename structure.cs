using System;

class ProgramStructure
{
    // Entry point of the program
    static void Main(string[] args)
    {
        // Example of a simple print statement
        Console.WriteLine("Welcome to C# Programming!");

        // Calling a method
        DisplayMessage();

        // Creating an object of a class
        MyClass obj = new MyClass();
        obj.ShowMessage();
    }

    // Example method
    static void DisplayMessage()
    {
        Console.WriteLine("This is an example of C# structure and syntax.");
    }
}

// Example class
class MyClass
{
    public void ShowMessage()
    {
        Console.WriteLine("Hello from the MyClass object!");
    }
}
