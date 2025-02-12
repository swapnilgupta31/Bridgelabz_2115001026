using System;

// Node Class: Represents a Movie Record
class Movie {
    public string title;
    public string director;
    public int year;
    public double rating;
    public Movie next;
    public Movie prev;

    // Constructor
    public Movie(string title, string director, int year, double rating) {
        this.title = title;
        this.director = director;
        this.year = year;
        this.rating = rating;
        this.next = null;
        this.prev = null;
    }
}

// Doubly Linked List Class
class MovieList {
    private Movie head;
    private Movie tail;

    // Add Movie at Beginning
    public void AddAtBeginning(string title, string director, int year, double rating) {
        Movie newMovie = new Movie(title, director, year, rating);
        if (head == null) {
            head = tail = newMovie;
            return;
        }
        newMovie.next = head;
        head.prev = newMovie;
        head = newMovie;
    }

    // Add Movie at End
    public void AddAtEnd(string title, string director, int year, double rating) {
        Movie newMovie = new Movie(title, director, year, rating);
        if (head == null) {
            head = tail = newMovie;
            return;
        }
        tail.next = newMovie;
        newMovie.prev = tail;
        tail = newMovie;
    }

    // Add Movie at Specific Position (1-based index)
    public void AddAtPosition(int position, string title, string director, int year, double rating) {
        if (position < 1) {
            Console.WriteLine("Invalid position");
            return;
        }
        if (position == 1) {
            AddAtBeginning(title, director, year, rating);
            return;
        }
        Movie newMovie = new Movie(title, director, year, rating);
        Movie temp = head;
        for (int i = 1; temp != null && i < position - 1; i++) {
            temp = temp.next;
        }
        if (temp == null || temp.next == null) {
            AddAtEnd(title, director, year, rating);
            return;
        }
        newMovie.next = temp.next;
        newMovie.prev = temp;
        temp.next.prev = newMovie;
        temp.next = newMovie;
    }

    // Remove Movie by Title
    public void RemoveByTitle(string title) {
        if (head == null) {
            Console.WriteLine("List is empty");
            return;
        }
        if (head.title == title) {
            head = head.next;
            if (head != null) head.prev = null;
            return;
        }
        Movie temp = head;
        while (temp != null && temp.title != title) {
            temp = temp.next;
        }
        if (temp == null) {
            Console.WriteLine("Movie not found");
            return;
        }
        if (temp.next != null) temp.next.prev = temp.prev;
        if (temp.prev != null) temp.prev.next = temp.next;
        if (temp == tail) tail = temp.prev;
    }

    // Search Movie by Director or Rating
    public void SearchByDirectorOrRating(string director, double rating) {
        Movie temp = head;
        bool found = false;
        while (temp != null) {
            if (temp.director == director || temp.rating == rating) {
                Console.WriteLine("Title: " + temp.title + ", Director: " + temp.director + ", Year: " + temp.year + ", Rating: " + temp.rating);
                found = true;
            }
            temp = temp.next;
        }
        if (!found) Console.WriteLine("No matching movies found");
    }

    // Update Movie's Rating by Title
    public void UpdateRating(string title, double newRating) {
        Movie temp = head;
        while (temp != null) {
            if (temp.title == title) {
                temp.rating = newRating;
                Console.WriteLine("Rating updated for: " + title);
                return;
            }
            temp = temp.next;
        }
        Console.WriteLine("Movie not found");
    }

    // Display All Movies (Forward)
    public void DisplayAllForward() {
        if (head == null) {
            Console.WriteLine("No movie records available");
            return;
        }
        Movie temp = head;
        while (temp != null) {
            Console.WriteLine("Title: " + temp.title + ", Director: " + temp.director + ", Year: " + temp.year + ", Rating: " + temp.rating);
            temp = temp.next;
        }
    }

    // Display All Movies (Reverse)
    public void DisplayAllReverse() {
        if (tail == null) {
            Console.WriteLine("No movie records available");
            return;
        }
        Movie temp = tail;
        while (temp != null) {
            Console.WriteLine("Title: " + temp.title + ", Director: " + temp.director + ", Year: " + temp.year + ", Rating: " + temp.rating);
            temp = temp.prev;
        }
    }
}

// Main Program
class Program {
    static void Main() {
        MovieList movieList = new MovieList();

        // Adding movies
        movieList.AddAtBeginning("Inception", "Christopher Nolan", 2010, 8.8);
        movieList.AddAtEnd("Titanic", "James Cameron", 1997, 7.8);
        movieList.AddAtPosition(2, "Interstellar", "Christopher Nolan", 2014, 8.6);

        // Display all movies forward
        Console.WriteLine("All Movies (Forward Order):");
        movieList.DisplayAllForward();

        // Display all movies reverse
        Console.WriteLine("\nAll Movies (Reverse Order):");
        movieList.DisplayAllReverse();

        // Search for movies
        Console.WriteLine("\nSearching for movies by Director 'Christopher Nolan' or Rating 8.6:");
        movieList.SearchByDirectorOrRating("Christopher Nolan", 8.6);

        // Update rating
        Console.WriteLine("\nUpdating Rating for 'Titanic':");
        movieList.UpdateRating("Titanic", 8.0);
        movieList.DisplayAllForward();

        // Remove a movie
        Console.WriteLine("\nRemoving 'Interstellar':");
        movieList.RemoveByTitle("Interstellar");
        movieList.DisplayAllForward();
    }
}
