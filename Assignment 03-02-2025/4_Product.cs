using System;

class Product {
    static double discount = 10; // Static variable shared across all products
    public readonly int productID; // Readonly variable to ensure uniqueness
    public string productName;
    public double price;
    public int quantity;

    // Constructor to initialize product details
    public Product(int productID, string productName, double price, int quantity) {
        this.productID = productID; // 'this' differentiates instance and parameter variables
        this.productName = productName;
        this.price = price;
        this.quantity = quantity;
    }

    // Static method to update the discount
    public static void UpdateDiscount(double newDiscount) {
        discount = newDiscount;
    }

    // Method to display product details
    public void DisplayProductDetails() {
        if (this is Product) { // 'is' operator to validate type
            Console.WriteLine("\nProduct Name: " + productName);
            Console.WriteLine("Product ID: " + productID);
            Console.WriteLine("Price: $" + price);
            Console.WriteLine("Quantity: " + quantity);
            Console.WriteLine("Discount: " + discount + "%");
        } else {
            Console.WriteLine("Invalid Product");
        }
    }
}

// Main Program
class Program {
    static void Main() {
        // Creating product objects
        Product prod1 = new Product(101, "Laptop", 800, 2);
        Product prod2 = new Product(102, "Smartphone", 600, 3);

        // Displaying product details
        prod1.DisplayProductDetails();
        prod2.DisplayProductDetails();

        // Update and display the discount
        Product.UpdateDiscount(15); // Update discount
        Console.WriteLine("\nUpdated Discount: " + Product.discount + "%");
    }
}
