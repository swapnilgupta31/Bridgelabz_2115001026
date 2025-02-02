using System;

class Book {
    string title, author;
    int price;

    // Default Constructor
    public Book() {
        title = "Unknown";
        author = "Unknown";
        price = 0;
    }

    // Parameterized Constructor
    public Book(string title, string author, int price) {
        this.title = title;
        this.author = author;
        this.price = price;
    }

    public void Display() {
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + price);
    }
}

class Program {
    static void Main() {
        Book b1 = new Book(); // Default Constructor
        Book b2 = new Book("C# Programming", "John Doe", 500); // Parameterized Constructor

        Console.WriteLine("Default Book:");
        b1.Display();
        Console.WriteLine("\nParameterized Book:");
        b2.Display();
    }
}
