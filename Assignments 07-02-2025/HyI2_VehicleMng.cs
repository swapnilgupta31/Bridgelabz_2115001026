using System;

// Base class: Vehicle
class Vehicle {
    public int MaxSpeed { get; set; }
    public string Model { get; set; }

    public void DisplayVehicleInfo() {
        Console.WriteLine("Model: " + Model);
        Console.WriteLine("Maximum Speed: " + MaxSpeed + " km/h");
    }
}

// Interface: Refuelable
interface Refuelable {
    void Refuel();
}

// Subclass: ElectricVehicle (inherits from Vehicle)
class ElectricVehicle : Vehicle {
    public void Charge() {
        Console.WriteLine("Charging the electric vehicle...");
    }
}

// Subclass: PetrolVehicle (inherits from Vehicle, implements Refuelable)
class PetrolVehicle : Vehicle, Refuelable {
    public void Refuel() {
        Console.WriteLine("Refueling the petrol vehicle...");
    }
}

// Main program
class Program {
    public static void Main(string[] args) {
        ElectricVehicle tesla = new ElectricVehicle();
        tesla.Model = "Tesla Model S";
        tesla.MaxSpeed = 250;

        PetrolVehicle honda = new PetrolVehicle();
        honda.Model = "Honda Civic";
        honda.MaxSpeed = 220;

        // Displaying vehicle information
        tesla.DisplayVehicleInfo();
        tesla.Charge();
        Console.WriteLine();

        honda.DisplayVehicleInfo();
        honda.Refuel();
    }
}
