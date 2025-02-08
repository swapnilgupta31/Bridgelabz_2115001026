using System;

class Vehicle {
    public int MaxSpeed { get; set; } // Maximum speed of the vehicle
    public string FuelType { get; set; } // Type of fuel used

    public virtual void DisplayInfo() {
        Console.WriteLine("Maximum Speed: " + MaxSpeed + " km/h");
        Console.WriteLine("Fuel Type: " + FuelType);
    }
}

// Car subclass
class Car : Vehicle {
    public int SeatCapacity { get; set; } // Number of seats

    public override void DisplayInfo() {
        Console.WriteLine("Vehicle Type: Car");
        base.DisplayInfo(); // Calls base class method
        Console.WriteLine("Seating Capacity: " + SeatCapacity + "\n");
    }
}

// Truck subclass
class Truck : Vehicle {
    public int PayloadCapacity { get; set; } // Payload capacity in kg

    public override void DisplayInfo() {
        Console.WriteLine("Vehicle Type: Truck");
        base.DisplayInfo();
        Console.WriteLine("Payload Capacity: " + PayloadCapacity + " kg" + "\n");
    }
}

// Motorcycle subclass
class Motorcycle : Vehicle {
    public bool HasSidecar { get; set; } // Whether the motorcycle has a sidecar

    public override void DisplayInfo() {
        Console.WriteLine("Vehicle Type: Motorcycle");
        base.DisplayInfo();
        Console.WriteLine("Has Sidecar: " + (HasSidecar ? "Yes" : "No") + "\n");
    }
}

class Program {
    public static void Main(string[] args) {
        // Creating and displaying different vehicle types
        Vehicle car = new Car { MaxSpeed = 200, FuelType = "Petrol", SeatCapacity = 5 };
        Vehicle truck = new Truck { MaxSpeed = 120, FuelType = "Diesel", PayloadCapacity = 5000 };
        Vehicle motorcycle = new Motorcycle { MaxSpeed = 180, FuelType = "Petrol", HasSidecar = false };

        // Calling DisplayInfo on each vehicle
        car.DisplayInfo();

        truck.DisplayInfo();

        motorcycle.DisplayInfo();
    }
}
