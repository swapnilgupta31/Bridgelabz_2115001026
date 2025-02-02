using System;

class Product {
    string productName;
    int price;
    static int totalProducts = 0; // Class Variable

    // Constructor
    public Product(string productName, int price) {
        this.productName = productName;
        this.price = price;
        totalProducts++; // Every time a product is created, count increases
    }

    // Instance Method to display product details
    public void DisplayProductDetails() {
        Console.WriteLine("Product Name: " + productName);
        Console.WriteLine("Price: Rs. " + price);
    }

    // Class Method to display total products
    public static void DisplayTotalProducts() {
        Console.WriteLine("Total Products Created: " + totalProducts);
    }
}

class Program {
    static void Main() {
        Product p1 = new Product("Laptop", 50000);
        Product p2 = new Product("Phone", 20000);

        Console.WriteLine("Product 1 Details:");
        p1.DisplayProductDetails();
        
        Console.WriteLine("\nProduct 2 Details:");
        p2.DisplayProductDetails();

        Console.WriteLine("\nInventory Summary:");
        Product.DisplayTotalProducts();
    }
}
