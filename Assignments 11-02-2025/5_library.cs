using System;

// Node Class: Represents a Book
class BookNode {
    public int bookId;
    public string bookTitle;
    public string author;
    public string genre;
    public bool isAvailable;
    public BookNode next;
    public BookNode prev;

    // Constructor
    public BookNode(int bookId, string bookTitle, string author, string genre, bool isAvailable) {
        this.bookId = bookId;
        this.bookTitle = bookTitle;
        this.author = author;
        this.genre = genre;
        this.isAvailable = isAvailable;
        this.next = null;
        this.prev = null;
    }
}

// Doubly Linked List Class
class LibraryManager {
    private BookNode head = null;
    private BookNode tail = null;

    // Add Book at Beginning
    public void AddAtBeginning(int bookId, string bookTitle, string author, string genre, bool isAvailable) {
        BookNode newBook = new BookNode(bookId, bookTitle, author, genre, isAvailable);
        if (head == null) {
            head = tail = newBook;
        } else {
            newBook.next = head;
            head.prev = newBook;
            head = newBook;
        }
    }

    // Add Book at End
    public void AddAtEnd(int bookId, string bookTitle, string author, string genre, bool isAvailable) {
        BookNode newBook = new BookNode(bookId, bookTitle, author, genre, isAvailable);
        if (head == null) {
            head = tail = newBook;
        } else {
            tail.next = newBook;
            newBook.prev = tail;
            tail = newBook;
        }
    }

    // Add Book at Specific Position (1-based index)
    public void AddAtPosition(int position, int bookId, string bookTitle, string author, string genre, bool isAvailable) {
        if (position < 1) {
            Console.WriteLine("Invalid position");
            return;
        }
        if (position == 1) {
            AddAtBeginning(bookId, bookTitle, author, genre, isAvailable);
            return;
        }
        BookNode newBook = new BookNode(bookId, bookTitle, author, genre, isAvailable);
        BookNode temp = head;
        for (int i = 1; temp != null && i < position - 1; i++) {
            temp = temp.next;
        }
        if (temp == null) {
            Console.WriteLine("Position out of bounds");
            return;
        }
        newBook.next = temp.next;
        newBook.prev = temp;
        if (temp.next != null) {
            temp.next.prev = newBook;
        } else {
            tail = newBook;
        }
        temp.next = newBook;
    }

    // Remove Book by Book ID
    public void RemoveByBookId(int bookId) {
        if (head == null) {
            Console.WriteLine("Library is empty");
            return;
        }
        BookNode temp = head;
        while (temp != null && temp.bookId != bookId) {
            temp = temp.next;
        }
        if (temp == null) {
            Console.WriteLine("Book not found");
            return;
        }
        if (temp.prev != null) {
            temp.prev.next = temp.next;
        } else {
            head = temp.next;
        }
        if (temp.next != null) {
            temp.next.prev = temp.prev;
        } else {
            tail = temp.prev;
        }
    }

    // Search Book by Book Title
    public void SearchByTitle(string bookTitle) {
        BookNode temp = head;
        bool found = false;
        while (temp != null) {
            if (temp.bookTitle.Equals(bookTitle, StringComparison.OrdinalIgnoreCase)) {
                Console.WriteLine("ID: " + temp.bookId + ", Author: " + temp.author + ", Genre: " + temp.genre + 
                                  ", Available: " + temp.isAvailable);
                found = true;
            }
            temp = temp.next;
        }
        if (!found) Console.WriteLine("Book not found");
    }

    // Search Book by Author
    public void SearchByAuthor(string author) {
        BookNode temp = head;
        bool found = false;
        while (temp != null) {
            if (temp.author.Equals(author, StringComparison.OrdinalIgnoreCase)) {
                Console.WriteLine("ID: " + temp.bookId + ", Title: " + temp.bookTitle + ", Genre: " + temp.genre + 
                                  ", Available: " + temp.isAvailable);
                found = true;
            }
            temp = temp.next;
        }
        if (!found) Console.WriteLine("No books found by this author");
    }

    // Update Availability Status by Book ID
    public void UpdateAvailability(int bookId, bool isAvailable) {
        BookNode temp = head;
        while (temp != null) {
            if (temp.bookId == bookId) {
                temp.isAvailable = isAvailable;
                return;
            }
            temp = temp.next;
        }
        Console.WriteLine("Book not found");
    }

    // Display All Books in Forward Order
    public void DisplayForward() {
        if (head == null) {
            Console.WriteLine("Library is empty");
            return;
        }
        BookNode temp = head;
        while (temp != null) {
            Console.WriteLine("ID: " + temp.bookId + ", Title: " + temp.bookTitle + ", Author: " + temp.author +
                              ", Genre: " + temp.genre + ", Available: " + temp.isAvailable);
            temp = temp.next;
        }
    }

    // Display All Books in Reverse Order
    public void DisplayReverse() {
        if (tail == null) {
            Console.WriteLine("Library is empty");
            return;
        }
        BookNode temp = tail;
        while (temp != null) {
            Console.WriteLine("ID: " + temp.bookId + ", Title: " + temp.bookTitle + ", Author: " + temp.author +
                              ", Genre: " + temp.genre + ", Available: " + temp.isAvailable);
            temp = temp.prev;
        }
    }

    // Count Total Number of Books
    public int CountBooks() {
        int count = 0;
        BookNode temp = head;
        while (temp != null) {
            count++;
            temp = temp.next;
        }
        return count;
    }
}

// Main Program
class Program {
    static void Main() {
        LibraryManager library = new LibraryManager();

        // Adding books
        library.AddAtBeginning(101, "The Great Gatsby", "F. Scott Fitzgerald", "Fiction", true);
        library.AddAtEnd(102, "1984", "George Orwell", "Dystopian", true);
        library.AddAtPosition(2, 103, "To Kill a Mockingbird", "Harper Lee", "Classic", false);

        // Display library
        Console.WriteLine("Books in Library:");
        library.DisplayForward();

        // Update availability status
        Console.WriteLine("\nUpdating availability of Book ID 103:");
        library.UpdateAvailability(103, true);
        library.DisplayForward();

        // Search for a book
        Console.WriteLine("\nSearching for '1984':");
        library.SearchByTitle("1984");

        // Count total books
        Console.WriteLine("\nTotal Books in Library: " + library.CountBooks());

        // Display in reverse order
        Console.WriteLine("\nBooks in Reverse Order:");
        library.DisplayReverse();
    }
}
