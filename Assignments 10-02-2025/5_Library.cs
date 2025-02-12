using System;
using System.Collections.Generic;

// Abstract Class: LibraryItem
abstract class LibraryItem {
    protected int itemId;
    protected string title;
    protected string author;

    // Constructor
    public LibraryItem(int itemId, string title, string author) {
        this.itemId = itemId;
        this.title = title;
        this.author = author;
    }

    // Abstract Method for Loan Duration
    public abstract int GetLoanDuration();

    // Method to Display Item Details
    public void GetItemDetails() {
        Console.WriteLine("Item ID: " + itemId + ", Title: " + title + ", Author: " + author);
    }
}

// Interface for Reservable Items
interface IReservable {
    void ReserveItem();
    bool CheckAvailability();
}

// Concrete Class: Book (Implements IReservable)
class Book : LibraryItem, IReservable {
    private bool isAvailable = true;

    public Book(int itemId, string title, string author) : base(itemId, title, author) {}

    public override int GetLoanDuration() {
        return 14; // 14 days loan duration for books
    }

    public void ReserveItem() {
        if (isAvailable) {
            isAvailable = false;
            Console.WriteLine("Book Reserved Successfully.");
        } else {
            Console.WriteLine("Book is already reserved.");
        }
    }

    public bool CheckAvailability() {
        return isAvailable;
    }
}

// Concrete Class: Magazine (No Reservations)
class Magazine : LibraryItem {
    public Magazine(int itemId, string title, string author) : base(itemId, title, author) {}

    public override int GetLoanDuration() {
        return 7; // 7 days loan duration for magazines
    }
}

// Concrete Class: DVD (Implements IReservable)
class DVD : LibraryItem, IReservable {
    private bool isAvailable = true;

    public DVD(int itemId, string title, string author) : base(itemId, title, author) {}

    public override int GetLoanDuration() {
        return 5; // 5 days loan duration for DVDs
    }

    public void ReserveItem() {
        if (isAvailable) {
            isAvailable = false;
            Console.WriteLine("DVD Reserved Successfully.");
        } else {
            Console.WriteLine("DVD is already reserved.");
        }
    }

    public bool CheckAvailability() {
        return isAvailable;
    }
}

// Main Program
class Program {
    static void Main() {
        // Creating Library Items
        List<LibraryItem> items = new List<LibraryItem> {
            new Book(101, "The Great Gatsby", "F. Scott Fitzgerald"),
            new Magazine(102, "National Geographic", "Editorial Team"),
            new DVD(103, "Inception", "Christopher Nolan")
        };

        // Displaying Library Items and Loan Duration
        foreach (LibraryItem item in items) {
            item.GetItemDetails();
            Console.WriteLine("Loan Duration: " + item.GetLoanDuration() + " days");

            // Explicit Type Checking for Reservations
            if (item is Book) {
                Console.WriteLine("Availability: " + ((Book)item).CheckAvailability());
                ((Book)item).ReserveItem();
            } else if (item is DVD) {
                Console.WriteLine("Availability: " + ((DVD)item).CheckAvailability());
                ((DVD)item).ReserveItem();
            }

            Console.WriteLine();
        }
    }
}
