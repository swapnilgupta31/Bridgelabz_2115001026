using System;
using System.Collections.Generic;

// Abstract class for warehouse items
abstract class WarehouseItem {
    public string Name { get; set; }
}

// Electronics category
class Electronics : WarehouseItem {
    public Electronics(string name) { Name = name; }
}

// Groceries category
class Groceries : WarehouseItem {
    public Groceries(string name) { Name = name; }
}

// Generic Storage class for warehouse items
class Storage<T> where T : WarehouseItem {
    private List<T> items = new List<T>();

    public void AddItem(T item) {
        items.Add(item);
    }

    public void DisplayItems() {
        foreach (T item in items) {
            Console.WriteLine("Item: " + item.Name);
        }
    }
}

// Test the storage system
class Program {
    static void Main() {
        Storage<Electronics> electronicsStorage = new Storage<Electronics>();
        electronicsStorage.AddItem(new Electronics("Laptop"));
        electronicsStorage.AddItem(new Electronics("Smartphone"));

        Storage<Groceries> groceryStorage = new Storage<Groceries>();
        groceryStorage.AddItem(new Groceries("Apple"));
        groceryStorage.AddItem(new Groceries("Milk"));

        Console.WriteLine("Electronics Storage:");
        electronicsStorage.DisplayItems();

        Console.WriteLine("\nGrocery Storage:");
        groceryStorage.DisplayItems();
    }
}
