using System;

class CarRental {
    string customerName, carModel;
    int rentalDays, totalCost;

    public CarRental(string customerName, string carModel, int rentalDays) {
        this.customerName = customerName;
        this.carModel = carModel;
        this.rentalDays = rentalDays;
        this.totalCost = CalculateCost();
    }

    private int CalculateCost() {
        return rentalDays * 500; // Rs. 500 per day
    }

    public void Display() {
        Console.WriteLine("Customer Name: " + customerName);
        Console.WriteLine("Car Model: " + carModel);
        Console.WriteLine("Rental Days: " + rentalDays);
        Console.WriteLine("Total Cost: Rs. " + totalCost);
    }
}

class Program {
    static void Main() {
        CarRental rental = new CarRental("Alice", "Toyota", 4);
        rental.Display();
    }
}
