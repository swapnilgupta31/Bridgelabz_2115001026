
using System;

// Abstract class for Product Category
abstract class ProductCategory {
    public string Name { get; set; }
}

// Book category
class BookCategory : ProductCategory {
    public BookCategory(string name) { Name = name; }
}

// Clothing category
class ClothingCategory : ProductCategory {
    public ClothingCategory(string name) { Name = name; }
}

// Generic Product class
class Product<T> where T : ProductCategory {
    public string ProductName { get; set; }
    public double Price { get; set; }
    public T Category { get; set; }

    public Product(string name, double price, T category) {
        ProductName = name;
        Price = price;
        Category = category;
    }

    public void DisplayProduct() {
        Console.WriteLine("Product: " + ProductName + ", Category: " + Category.Name + ", Price: $" + Price);
    }
}

// Generic discount method
class Discount {
    public static void ApplyDiscount<T>(T product, double percentage) where T : Product<ProductCategory> {
        product.Price -= product.Price * (percentage / 100);
    }
}

// Test the marketplace
class Program {
    static void Main() {
        Product<BookCategory> book = new Product<BookCategory>("C# Programming", 50, new BookCategory("Books"));
        Product<ClothingCategory> shirt = new Product<ClothingCategory>("T-Shirt", 20, new ClothingCategory("Clothing"));

        Console.WriteLine("Before Discount:");
        book.DisplayProduct();
        shirt.DisplayProduct();

        Discount.ApplyDiscount(book, 10);
        Discount.ApplyDiscount(shirt, 20);

        Console.WriteLine("\nAfter Discount:");
        book.DisplayProduct();
        shirt.DisplayProduct();
    }
}

