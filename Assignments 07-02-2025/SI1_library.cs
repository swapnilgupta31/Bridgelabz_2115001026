
using System;

class Book {
    public string Title { get; set; } // Book title
    public int PublicationYear { get; set; } // Year of publication

    public virtual void DisplayInfo() {
        Console.WriteLine("Book Title: " + Title);
        Console.WriteLine("Publication Year: " + PublicationYear);
    }
}

// Author subclass that extends Book
class Author : Book {
    public string Name { get; set; } // Author name
    public string Bio { get; set; } // Short biography

    public override void DisplayInfo() {
        base.DisplayInfo(); // Call base class method
        Console.WriteLine("Author: " + Name);
        Console.WriteLine("Biography: " + Bio);
    }
}

class Program {
    public static void Main(string[] args) {
        // Creating an Author object (which includes Book details)
        Author book1 = new Author {
            Title = "The C# Programming Guide",
            PublicationYear = 2022,
            Name = "John Doe",
            Bio = "A software engineer and technical writer."
        };

        // Display book and author information
        book1.DisplayInfo();
    }
}
