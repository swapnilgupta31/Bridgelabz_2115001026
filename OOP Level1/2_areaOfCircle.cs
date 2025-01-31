using System;

class Circle{
    private double radius; // Circle radius

    // Constructor to initialize radius
    public Circle(double radius){
        this.radius = radius;
    }

    // Method to calculate area
    public double CalculateArea(){
        return 3.1416 * radius * radius;
    }

    // Method to calculate circumference
    public double CalculateCircumference(){
        return 2 * 3.1416 * radius;
    }

    // Method to display details
    public void DisplayDetails(){
        Console.WriteLine("Radius: " + radius);
        Console.WriteLine("Area: " + CalculateArea());
        Console.WriteLine("Circumference: " + CalculateCircumference());
    }
}

class Program{
    static void Main(){
        // Creating Circle objects
        Circle circle1 = new Circle(5);
        Circle circle2 = new Circle(7);

        // Displaying details
        Console.WriteLine(" Circle 1 ");
        circle1.DisplayDetails();

        Console.WriteLine("\n Circle 2 ");
        circle2.DisplayDetails();
    }
}
