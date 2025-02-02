using System;

class Vehicle {
    string ownerName, vehicleType;
    static int registrationFee = 5000; // Class Variable

    // Constructor
    public Vehicle(string ownerName, string vehicleType) {
        this.ownerName = ownerName;
        this.vehicleType = vehicleType;
    }

    // Instance Method to display vehicle details
    public void DisplayVehicleDetails() {
        Console.WriteLine("Owner Name: " + ownerName);
        Console.WriteLine("Vehicle Type: " + vehicleType);
        Console.WriteLine("Registration Fee: Rs. " + registrationFee);
    }

    // Class Method to update registration fee
    public static void UpdateRegistrationFee(int newFee) {
        registrationFee = newFee;
    }
}

class Program {
    static void Main() {
        Vehicle v1 = new Vehicle("Alice", "Car");
        Vehicle v2 = new Vehicle("Bob", "Bike");

        Console.WriteLine("Before Registration Fee Update:");
        v1.DisplayVehicleDetails();
        Console.WriteLine();
        v2.DisplayVehicleDetails();

        Console.WriteLine("\nUpdating Registration Fee...");
        Vehicle.UpdateRegistrationFee(6000);

        Console.WriteLine("\nAfter Registration Fee Update:");
        v1.DisplayVehicleDetails();
        Console.WriteLine();
        v2.DisplayVehicleDetails();
    }
}
