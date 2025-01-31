using System;

class Book{
    private string title, author; // Book title and author
    private double price; // Book price

    // Constructor to initialize book details
    public Book(string title, string author, double price){
        this.title = title;
        this.author = author;
        this.price = price;
    }

    // Method to display book details
    public void DisplayDetails(){
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: $" + price);
    }
}

class Program{
    static void Main(){
        // Creating Book objects
        Book book1 = new Book("The Alchemist", "Paulo Coelho", 15.99);
        Book book2 = new Book("1984", "George Orwell", 12.50);

        // Displaying book details
        Console.WriteLine(" Book 1 ");
        book1.DisplayDetails();

        Console.WriteLine("\n Book 2 ");
        book2.DisplayDetails();
    }
}
