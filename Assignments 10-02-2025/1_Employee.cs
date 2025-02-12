using System;
using System.Collections.Generic;

// Abstract Class: Product
abstract class Product {
    protected int productId;
    protected string name;
    protected double price;

    // Constructor
    public Product(int productId, string name, double price) {
        this.productId = productId;
        this.name = name;
        this.price = price;
    }

    // Abstract Method for Discount Calculation
    public abstract double CalculateDiscount();

    // Method to Display Product Details
    public void DisplayDetails() {
        Console.WriteLine("Product ID: " + productId + ", Name: " + name + ", Price: " + price);
    }

    // Method to Get Final Price after Tax & Discount
    public abstract double GetFinalPrice();
}

// Interface for Tax Calculation
interface ITaxable {
    double CalculateTax();
    string GetTaxDetails();
}

// Concrete Class: Electronics (Implements ITaxable)
class Electronics : Product, ITaxable {
    public Electronics(int productId, string name, double price) : base(productId, name, price) {}

    public override double CalculateDiscount() {
        return price * 0.10; // 10% Discount
    }

    public double CalculateTax() {
        return price * 0.18; // 18% GST on Electronics
    }

    public string GetTaxDetails() {
        return "Electronics Tax: 18% GST";
    }

    public override double GetFinalPrice() {
        return price + CalculateTax() - CalculateDiscount();
    }
}

// Concrete Class: Clothing (Implements ITaxable)
class Clothing : Product, ITaxable {
    public Clothing(int productId, string name, double price) : base(productId, name, price) {}

    public override double CalculateDiscount() {
        return price * 0.05; // 5% Discount
    }

    public double CalculateTax() {
        return price * 0.12; // 12% GST on Clothing
    }

    public string GetTaxDetails() {
        return "Clothing Tax: 12% GST";
    }

    public override double GetFinalPrice() {
        return price + CalculateTax() - CalculateDiscount();
    }
}

// Concrete Class: Groceries (No Tax, Only Discount)
class Groceries : Product {
    public Groceries(int productId, string name, double price) : base(productId, name, price) {}

    public override double CalculateDiscount() {
        return price * 0.02; // 2% Discount
    }

    public override double GetFinalPrice() {
        return price - CalculateDiscount();
    }
}

// Main Program
class Program {
    static void Main() {
        // Creating Product List
        List<Product> products = new List<Product> {
            new Electronics(101, "Laptop", 50000),
            new Clothing(102, "T-Shirt", 1000),
            new Groceries(103, "Rice", 500)
        };

        // Displaying Product Details
        foreach (Product p in products) {
            p.DisplayDetails();
            Console.WriteLine("Final Price: " + p.GetFinalPrice());

            // Explicit Type Checking for ITaxable Products
            if (p is Electronics) {
                Console.WriteLine(((Electronics)p).GetTaxDetails());
            } else if (p is Clothing) {
                Console.WriteLine(((Clothing)p).GetTaxDetails());
            }

            Console.WriteLine();
        }
    }
}
