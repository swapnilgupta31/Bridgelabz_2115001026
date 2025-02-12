using System;
using System.Collections.Generic;

// Abstract Class: Vehicle
abstract class Vehicle {
    protected string vehicleNumber;
    protected string type;
    protected double rentalRate;

    // Constructor
    public Vehicle(string vehicleNumber, string type, double rentalRate) {
        this.vehicleNumber = vehicleNumber;
        this.type = type;
        this.rentalRate = rentalRate;
    }

    // Abstract Method for Rental Cost Calculation
    public abstract double CalculateRentalCost(int days);

    // Method to Display Vehicle Details
    public void DisplayDetails() {
        Console.WriteLine("Vehicle No: " + vehicleNumber + ", Type: " + type + ", Rental Rate: " + rentalRate);
    }
}

// Interface for Insurance
interface IInsurable {
    double CalculateInsurance();
    string GetInsuranceDetails();
}

// Concrete Class: Car (Implements IInsurable)
class Car : Vehicle, IInsurable {
    private string insurancePolicyNumber;

    public Car(string vehicleNumber, double rentalRate, string insurancePolicyNumber) : base(vehicleNumber, "Car", rentalRate) {
        this.insurancePolicyNumber = insurancePolicyNumber;
    }

    public override double CalculateRentalCost(int days) {
        return rentalRate * days;
    }

    public double CalculateInsurance() {
        return rentalRate * 0.15; // 15% insurance charge
    }

    public string GetInsuranceDetails() {
        return "Car Insurance Policy: " + insurancePolicyNumber;
    }
}

// Concrete Class: Bike (Implements IInsurable)
class Bike : Vehicle, IInsurable {
    private string insurancePolicyNumber;

    public Bike(string vehicleNumber, double rentalRate, string insurancePolicyNumber) : base(vehicleNumber, "Bike", rentalRate) {
        this.insurancePolicyNumber = insurancePolicyNumber;
    }

    public override double CalculateRentalCost(int days) {
        return rentalRate * days * 0.9; // 10% discount on long-term rentals
    }

    public double CalculateInsurance() {
        return rentalRate * 0.10; // 10% insurance charge
    }

    public string GetInsuranceDetails() {
        return "Bike Insurance Policy: " + insurancePolicyNumber;
    }
}

// Concrete Class: Truck (No Insurance)
class Truck : Vehicle {
    public Truck(string vehicleNumber, double rentalRate) : base(vehicleNumber, "Truck", rentalRate) {}

    public override double CalculateRentalCost(int days) {
        return rentalRate * days * 1.2; // 20% extra charge for maintenance
    }
}

// Main Program
class Program {
    static void Main() {
        // Creating Vehicle List
        List<Vehicle> vehicles = new List<Vehicle> {
            new Car("CAR123", 2000, "C12345"),
            new Bike("BIKE456", 500, "B67890"),
            new Truck("TRUCK789", 5000)
        };

        int rentalDays = 5; // Rental period for calculation

        // Displaying Vehicle Details and Costs
        foreach (Vehicle v in vehicles) {
            v.DisplayDetails();
            Console.WriteLine("Rental Cost for " + rentalDays + " days: " + v.CalculateRentalCost(rentalDays));

            // Explicit Type Checking for IInsurable Vehicles
            if (v is Car) {
                Console.WriteLine(((Car)v).GetInsuranceDetails());
                Console.WriteLine("Insurance Cost: " + ((Car)v).CalculateInsurance());
            } else if (v is Bike) {
                Console.WriteLine(((Bike)v).GetInsuranceDetails());
                Console.WriteLine("Insurance Cost: " + ((Bike)v).CalculateInsurance());
            }

            Console.WriteLine();
        }
    }
}
