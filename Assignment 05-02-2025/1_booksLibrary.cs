using System;
using System.Collections.Generic;
class Book{
    public string Title{get;set;}
    public string Author{get;set;}

//Constructor of class Book
    public Book(string title , string author){
        Title = title ;
        Author = author;
    }

    public void DisplayBookInfo(){
        Console.WriteLine("Title: " + Title + ", Author : " + Author);
    }

}
class Library{
    public string Name {get; set;}
    private List<Book> books;

    public Library(string name){
        Name = name;
        books = new List<Book>(); //initialize book list
    }

    public void AddBook(Book book){
        books.Add(book);
    }

    public void DisplayLibraryBooks(){
        Console.WriteLine("Linrary: "+Name);
        if (books.Count == 0){
            Console.WriteLine("No books in the library");
        }
        else{
            foreach (Book book in books){
                book.DisplayBookInfo();
            }
        }
    }
}
class Program {
    static void Main() {
        // Creating Books
        Book book1 = new Book("C# Basics", "John Doe");
        Book book2 = new Book("Object-Oriented Programming", "Jane Smith");
        Book book3 = new Book("Data Structures", "Alice Brown");

        // Creating Libraries
        Library library1 = new Library("City Library");
        Library library2 = new Library("University Library");

        // Adding Books to Libraries
        library1.AddBook(book1);
        library1.AddBook(book2);

        library2.AddBook(book2);
        library2.AddBook(book3);

        // Displaying Library Books
        library1.DisplayLibraryBooks();
        Console.WriteLine();
        library2.DisplayLibraryBooks();
    }
}