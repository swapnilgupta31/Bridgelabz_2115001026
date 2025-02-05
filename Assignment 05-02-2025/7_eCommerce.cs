using System;
using System.Collections.Generic;

class Product {
    public string ProductName { get; set; }
    public double Price { get; set; }

    public Product(string name, double price) {
        ProductName = name;
        Price = price;
    }

    public void DisplayProduct() {
        Console.WriteLine("Product: " + ProductName + ", Price: $" + Price);
    }
}

class Order {
    public int OrderId { get; set; }
    private List<Product> products;

    public Order(int orderId) {
        OrderId = orderId;
        products = new List<Product>();
    }

    public void AddProduct(Product product) {
        products.Add(product);
    }

    public void ShowOrderDetails() {
        Console.WriteLine("Order ID: " + OrderId);
        Console.WriteLine("Products in this Order:");
        foreach (var product in products) {
            product.DisplayProduct();
        }
    }
}

class Customer {
    public string CustomerName { get; set; }
    private List<Order> orders;

    public Customer(string name) {
        CustomerName = name;
        orders = new List<Order>();
    }

    public void PlaceOrder(Order order) {
        orders.Add(order);
        Console.WriteLine(CustomerName + " placed an order (ID: " + order.OrderId + ")");
    }

    public void ShowOrders() {
        Console.WriteLine("Orders for Customer: " + CustomerName);
        foreach (var order in orders) {
            order.ShowOrderDetails();
        }
    }
}

class Program {
    static void Main() {
        // Creating Products
        Product p1 = new Product("Laptop", 1000);
        Product p2 = new Product("Phone", 500);

        // Creating Customer
        Customer customer = new Customer("Alice");

        // Creating Orders
        Order order1 = new Order(101);
        order1.AddProduct(p1);
        order1.AddProduct(p2);

        // Customer places the order
        customer.PlaceOrder(order1);

        // Display all orders of customer
        customer.ShowOrders();
    }
}
