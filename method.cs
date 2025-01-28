using System;
class Program
{
    void Greet()
    {
        Console.WriteLine("Hello");
        Console.WriteLine("How do you do?");
    }
    static void Main(string[] args)
    {
        // Create an instance of the Program class
        Program obj = new Program();
        // Call the Greet method
        obj.Greet();
    }
}
