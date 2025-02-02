using System;

class Book {
    public string ISBN;
    protected string title;
    private string author;

    // Constructor
    public Book(string ISBN, string title, string author) {
        this.ISBN = ISBN;
        this.title = title;
        this.author = author;
    }

    // Public method to get author
    public string GetAuthor() {
        return author;
    }

    // Public method to set author
    public void SetAuthor(string newAuthor) {
        author = newAuthor;
    }
}

// Subclass using protected member
class EBook : Book {
    public int fileSize;

    public EBook(string ISBN, string title, string author, int fileSize)
        : base(ISBN, title, author) {
        this.fileSize = fileSize;
    }

    public void DisplayBookDetails() {
        Console.WriteLine("ISBN: " + ISBN);
        Console.WriteLine("Title: " + title); // Protected member accessible
        Console.WriteLine("File Size: " + fileSize + "MB");
    }
}

class Program {
    static void Main() {
        EBook ebook = new EBook("123-456-789", "C# Basics", "John Doe", 5);
        ebook.DisplayBookDetails();

        Console.WriteLine("Author: " + ebook.GetAuthor());

        ebook.SetAuthor("Jane Doe");
        Console.WriteLine("Updated Author: " + ebook.GetAuthor());
    }
}
