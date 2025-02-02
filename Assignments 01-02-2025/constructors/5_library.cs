using System;

class Book {
    string title, author;
    int price;
    bool available;

    public Book(string title, string author, int price) {
        this.title = title;
        this.author = author;
        this.price = price;
        this.available = true;
    }

    public void BorrowBook() {
        if (available) {
            available = false;
            Console.WriteLine("Book borrowed successfully.");
        } else {
            Console.WriteLine("Book is not available.");
        }
    }

    public void Display() {
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + price);
        Console.WriteLine("Available: " + (available ? "Yes" : "No"));
    }
}

class Program {
    static void Main() {
        Book b = new Book("C# Basics", "John Doe", 300);

        Console.WriteLine("Before Borrowing:");
        b.Display();

        b.BorrowBook(); // Borrowing the book

        Console.WriteLine("\nAfter Borrowing:");
        b.Display();
    }
}
