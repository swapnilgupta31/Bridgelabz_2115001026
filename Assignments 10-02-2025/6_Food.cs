using System;
using System.Collections.Generic;

// Abstract Class: FoodItem
abstract class FoodItem {
    protected string itemName;
    protected double price;
    protected int quantity;

    // Constructor
    public FoodItem(string itemName, double price, int quantity) {
        this.itemName = itemName;
        this.price = price;
        this.quantity = quantity;
    }

    // Abstract Method for Total Price Calculation
    public abstract double CalculateTotalPrice();

    // Method to Display Food Item Details
    public void GetItemDetails() {
        Console.WriteLine("Item: " + itemName + ", Price: " + price + ", Quantity: " + quantity);
    }
}

// Interface for Discount Feature
interface IDiscountable {
    double ApplyDiscount();
    string GetDiscountDetails();
}

// Concrete Class: VegItem (Implements IDiscountable)
class VegItem : FoodItem, IDiscountable {
    public VegItem(string itemName, double price, int quantity) : base(itemName, price, quantity) {}

    public override double CalculateTotalPrice() {
        return (price * quantity) - ApplyDiscount();
    }

    public double ApplyDiscount() {
        return (price * quantity) * 0.05; // 5% discount on Veg Items
    }

    public string GetDiscountDetails() {
        return "Veg Discount: 5% off";
    }
}

// Concrete Class: NonVegItem (Implements IDiscountable)
class NonVegItem : FoodItem, IDiscountable {
    public NonVegItem(string itemName, double price, int quantity) : base(itemName, price, quantity) {}

    public override double CalculateTotalPrice() {
        return (price * quantity) - ApplyDiscount();
    }

    public double ApplyDiscount() {
        return (price * quantity) * 0.02; // 2% discount on Non-Veg Items
    }

    public string GetDiscountDetails() {
        return "Non-Veg Discount: 2% off";
    }
}

// Main Program
class Program {
    static void Main() {
        // Creating Food Item List
        List<FoodItem> foodItems = new List<FoodItem> {
            new VegItem("Paneer Tikka", 200, 2),
            new NonVegItem("Chicken Biryani", 350, 1),
            new VegItem("Veg Burger", 100, 3)
        };

        // Displaying Food Item Details & Total Price
        foreach (FoodItem item in foodItems) {
            item.GetItemDetails();
            Console.WriteLine("Total Price: " + item.CalculateTotalPrice());

            // Explicit Type Checking for Discounts
            if (item is VegItem) {
                Console.WriteLine(((VegItem)item).GetDiscountDetails());
            } else if (item is NonVegItem) {
                Console.WriteLine(((NonVegItem)item).GetDiscountDetails());
            }

            Console.WriteLine();
        }
    }
}
