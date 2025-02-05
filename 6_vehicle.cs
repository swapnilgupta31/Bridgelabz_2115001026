using System;

class Vehicle {
    static double registrationFee = 150; // Static variable shared across all vehicles
    public readonly string registrationNumber; // Readonly variable for unique registration number
    public string ownerName;
    public string vehicleType;

    // Constructor to initialize vehicle details
    public Vehicle(string registrationNumber, string ownerName, string vehicleType) {
        this.registrationNumber = registrationNumber; // 'this' differentiates instance and parameter variables
        this.ownerName = ownerName;
        this.vehicleType = vehicleType;
    }

    // Static method to update registration fee
    public static void UpdateRegistrationFee(double newFee) {
        registrationFee = newFee;
    }

    // Method to display vehicle details
    public void DisplayVehicleDetails() {
        if (this is Vehicle) { // 'is' operator to validate type
            Console.WriteLine("\nVehicle Registration Number: " + registrationNumber);
            Console.WriteLine("Owner: " + ownerName);
            Console.WriteLine("Vehicle Type: " + vehicleType);
            Console.WriteLine("Registration Fee: $" + registrationFee);
        } else {
            Console.WriteLine("Invalid Vehicle");
        }
    }
}

// Main Program
class Program {
    static void Main() {
        // Creating vehicle objects
        Vehicle vehicle1 = new Vehicle("AB12345", "John Smith", "Car");
        Vehicle vehicle2 = new Vehicle("CD67890", "Jane Doe", "Truck");

        // Displaying vehicle details
        vehicle1.DisplayVehicleDetails();
        vehicle2.DisplayVehicleDetails();

        // Update and display the registration fee
        Vehicle.UpdateRegistrationFee(200); // Update fee
        Console.WriteLine("\nUpdated Registration Fee: $" + Vehicle.registrationFee);
    }
}
