using System;

// Node Class: Represents a booked ticket
class Ticket {
    public int ticketId;
    public string customerName;
    public string movieName;
    public int seatNumber;
    public DateTime bookingTime;
    public Ticket next; // Pointer to the next ticket (circular structure)

    // Constructor
    public Ticket(int ticketId, string customerName, string movieName, int seatNumber) {
        this.ticketId = ticketId;
        this.customerName = customerName;
        this.movieName = movieName;
        this.seatNumber = seatNumber;
        this.bookingTime = DateTime.Now;
        this.next = null;
    }
}

// Circular Linked List: Manages ticket reservations
class TicketReservationSystem {
    private Ticket last; // Points to the last ticket
    private int ticketCount = 0; // Total number of booked tickets

    // Add a new ticket at the end of the circular list
    public void AddTicket(int ticketId, string customerName, string movieName, int seatNumber) {
        Ticket newTicket = new Ticket(ticketId, customerName, movieName, seatNumber);
        ticketCount++;

        if (last == null) {
            last = newTicket;
            last.next = last; // Circular reference
        } else {
            newTicket.next = last.next;
            last.next = newTicket;
            last = newTicket;
        }
    }

    // Remove a ticket by Ticket ID
    public void RemoveTicket(int ticketId) {
        if (last == null) {
            Console.WriteLine("No tickets available.");
            return;
        }

        Ticket current = last.next, prev = last;
        do {
            if (current.ticketId == ticketId) {
                if (current == last && current.next == last) {
                    last = null; // Only one ticket in the list
                } else {
                    prev.next = current.next;
                    if (current == last) {
                        last = prev; // Update last if needed
                    }
                }
                ticketCount--;
                Console.WriteLine("Ticket with ID " + ticketId + " removed.");
                return;
            }
            prev = current;
            current = current.next;
        } while (current != last.next);

        Console.WriteLine("Ticket not found.");
    }

    // Display all booked tickets
    public void DisplayTickets() {
        if (last == null) {
            Console.WriteLine("No tickets booked.");
            return;
        }

        Ticket temp = last.next;
        Console.WriteLine("\nBooked Tickets:");
        do {
            Console.WriteLine("Ticket ID: " + temp.ticketId + ", Customer: " + temp.customerName + 
                              ", Movie: " + temp.movieName + ", Seat: " + temp.seatNumber + 
                              ", Time: " + temp.bookingTime);
            temp = temp.next;
        } while (temp != last.next);
    }

    // Search for a ticket by Customer Name or Movie Name
    public void SearchTicket(string query) {
        if (last == null) {
            Console.WriteLine("No tickets available.");
            return;
        }

        Ticket temp = last.next;
        bool found = false;
        do {
            if (temp.customerName.Equals(query, StringComparison.OrdinalIgnoreCase) || 
                temp.movieName.Equals(query, StringComparison.OrdinalIgnoreCase)) {
                Console.WriteLine("Ticket Found - ID: " + temp.ticketId + ", Customer: " + temp.customerName + 
                                  ", Movie: " + temp.movieName + ", Seat: " + temp.seatNumber);
                found = true;
            }
            temp = temp.next;
        } while (temp != last.next);

        if (!found) {
            Console.WriteLine("No ticket found for: " + query);
        }
    }

    // Get the total number of booked tickets
    public int GetTotalTickets() {
        return ticketCount;
    }
}

// Main Program
class Program {
    static void Main() {
        TicketReservationSystem system = new TicketReservationSystem();

        // Adding tickets
        system.AddTicket(101, "Alice", "Avengers", 5);
        system.AddTicket(102, "Bob", "Batman", 12);
        system.AddTicket(103, "Charlie", "Spiderman", 8);

        // Display all tickets
        system.DisplayTickets();

        // Search for a ticket
        Console.WriteLine("\nSearching for tickets booked by 'Alice':");
        system.SearchTicket("Alice");

        Console.WriteLine("\nSearching for tickets for the movie 'Batman':");
        system.SearchTicket("Batman");

        // Remove a ticket
        Console.WriteLine("\nRemoving Ticket ID 102:");
        system.RemoveTicket(102);
        system.DisplayTickets();

        // Get total number of booked tickets
        Console.WriteLine("\nTotal tickets booked: " + system.GetTotalTickets());
    }
}
