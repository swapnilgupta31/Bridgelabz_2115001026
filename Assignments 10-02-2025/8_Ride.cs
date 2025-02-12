using System;
using System.Collections.Generic;

// Abstract Class: Vehicle
abstract class Vehicle {
    private int vehicleId;
    private string driverName;
    private double ratePerKm;

    // Constructor
    public Vehicle(int vehicleId, string driverName, double ratePerKm) {
        this.vehicleId = vehicleId;
        this.driverName = driverName;
        this.ratePerKm = ratePerKm;
    }

    // Abstract Method for Fare Calculation
    public abstract double CalculateFare(double distance);

    // Method to Display Vehicle Details
    public void GetVehicleDetails() {
        Console.WriteLine("Vehicle ID: " + vehicleId + ", Driver: " + driverName);
    }

    // Getter for RatePerKm
    public double GetRatePerKm() {
        return ratePerKm;
    }
}

// Interface for GPS Functionality
interface IGPS {
    string GetCurrentLocation();
    void UpdateLocation(string newLocation);
}

// Concrete Class: Car (Implements IGPS)
class Car : Vehicle, IGPS {
    private string currentLocation;

    public Car(int vehicleId, string driverName, double ratePerKm) : base(vehicleId, driverName, ratePerKm) {
        currentLocation = "Unknown";
    }

    public override double CalculateFare(double distance) {
        return GetRatePerKm() * distance; // Fare Calculation for Car
    }

    public string GetCurrentLocation() {
        return currentLocation;
    }

    public void UpdateLocation(string newLocation) {
        currentLocation = newLocation;
    }
}

// Concrete Class: Bike (Implements IGPS)
class Bike : Vehicle, IGPS {
    private string currentLocation;

    public Bike(int vehicleId, string driverName, double ratePerKm) : base(vehicleId, driverName, ratePerKm) {
        currentLocation = "Unknown";
    }

    public override double CalculateFare(double distance) {
        return GetRatePerKm() * distance * 0.9; // 10% Discount for Bikes
    }

    public string GetCurrentLocation() {
        return currentLocation;
    }

    public void UpdateLocation(string newLocation) {
        currentLocation = newLocation;
    }
}

// Concrete Class: Auto (Implements IGPS)
class Auto : Vehicle, IGPS {
    private string currentLocation;

    public Auto(int vehicleId, string driverName, double ratePerKm) : base(vehicleId, driverName, ratePerKm) {
        currentLocation = "Unknown";
    }

    public override double CalculateFare(double distance) {
        return GetRatePerKm() * distance * 0.95; // 5% Discount for Auto
    }

    public string GetCurrentLocation() {
        return currentLocation;
    }

    public void UpdateLocation(string newLocation) {
        currentLocation = newLocation;
    }
}

// Main Program
class Program {
    static void Main() {
        // Creating Vehicle List
        List<Vehicle> vehicles = new List<Vehicle> {
            new Car(101, "John Doe", 15),
            new Bike(102, "Alice Smith", 10),
            new Auto(103, "David Johnson", 12)
        };

        // Distance for Fare Calculation
        double distance = 10; 

        // Displaying Vehicle Details and Fare Calculation
        foreach (Vehicle v in vehicles) {
            v.GetVehicleDetails();
            Console.WriteLine("Fare for " + distance + " km: " + v.CalculateFare(distance));

            // Explicit Type Checking for GPS
            if (v is Car) {
                Console.WriteLine("Current Location: " + ((Car)v).GetCurrentLocation());
            } else if (v is Bike) {
                Console.WriteLine("Current Location: " + ((Bike)v).GetCurrentLocation());
            } else if (v is Auto) {
                Console.WriteLine("Current Location: " + ((Auto)v).GetCurrentLocation());
            }

            Console.WriteLine();
        }
    }
}
