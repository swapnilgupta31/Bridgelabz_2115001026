using System;

class Book {
    static string libraryName = "City Library"; // Static variable (shared across all books)
    public readonly string ISBN; // Readonly variable (cannot be changed after assignment)
    public string Title; // Instance variable for book title
    public string Author; // Instance variable for author name

    // Constructor to initialize book details
    public Book(string ISBN, string Title, string Author) {
        this.ISBN = ISBN; // Using 'this' to differentiate instance variable
        this.Title = Title;
        this.Author = Author;
    }

    // Static method to display library name
    public static void DisplayLibraryName() {
        Console.WriteLine("Library: " + libraryName);
    }

    // Method to display book details
    public void DisplayBookDetails() {
        if (this is Book) { // Using 'is' to check type before displaying
            Console.WriteLine("\nLibrary: " + libraryName);
            Console.WriteLine("Book Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("ISBN: " + ISBN);
        } else {
            Console.WriteLine("Invalid Book");
        }
    }
}

// Main Program
class Program {
    static void Main() {
        // Creating book objects
        Book book1 = new Book("978-3-16-148410-0", "C# Programming", "John Doe");
        Book book2 = new Book("978-0-13-235088-4", "Introduction to Algorithms", "Thomas H. Cormen");

        // Display library name using static method
        Book.DisplayLibraryName();

        // Display book details
        book1.DisplayBookDetails();
        book2.DisplayBookDetails();
    }
}
