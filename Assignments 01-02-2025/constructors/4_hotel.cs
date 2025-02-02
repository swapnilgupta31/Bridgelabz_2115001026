using System;

class HotelBooking {
    string guestName, roomType;
    int nights;

    // Default Constructor
    public HotelBooking() {
        guestName = "Unknown";
        roomType = "Standard";
        nights = 1;
    }

    // Parameterized Constructor
    public HotelBooking(string guestName, string roomType, int nights) {
        this.guestName = guestName;
        this.roomType = roomType;
        this.nights = nights;
    }

    // Copy Constructor
    public HotelBooking(HotelBooking h) {
        this.guestName = h.guestName;
        this.roomType = h.roomType;
        this.nights = h.nights;
    }

    public void Display() {
        Console.WriteLine("Guest Name: " + guestName);
        Console.WriteLine("Room Type: " + roomType);
        Console.WriteLine("Nights: " + nights);
    }
}

class Program {
    static void Main() {
        HotelBooking hb1 = new HotelBooking("John Doe", "Deluxe", 3);
        HotelBooking hb2 = new HotelBooking(hb1); // Copy Constructor

        Console.WriteLine("Original Booking:");
        hb1.Display();
        Console.WriteLine("\nCopied Booking:");
        hb2.Display();
    }
}
