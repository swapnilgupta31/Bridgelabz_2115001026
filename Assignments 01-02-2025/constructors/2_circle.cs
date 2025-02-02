using System;

class Circle {
    int radius;

    // Default Constructor (Calls parameterized constructor)
    public Circle() : this(5) { }

    // Parameterized Constructor
    public Circle(int radius) {
        this.radius = radius;
    }

    public void Display() {
        Console.WriteLine("Radius: " + radius);
    }
}

class Program {
    static void Main() {
        Circle c1 = new Circle(); // Default Constructor
        Circle c2 = new Circle(10); // Parameterized Constructor

        Console.WriteLine("Default Circle:");
        c1.Display();
        Console.WriteLine("\nUser Defined Circle:");
        c2.Display();
    }
}
