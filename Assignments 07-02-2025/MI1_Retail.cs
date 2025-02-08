using System;

class Order {
    public int OrderID { get; set; } // Unique order ID
    public string OrderDate { get; set; } // Order date

    public virtual void GetOrderStatus() {
        Console.WriteLine("Order ID: " + OrderID);
        Console.WriteLine("Order Date: " + OrderDate);
        Console.WriteLine("Status: Order Placed");
    }
}

// ShippedOrder extends Order
class ShippedOrder : Order {
    public string TrackingNumber { get; set; } // Tracking number

    public override void GetOrderStatus() {
        base.GetOrderStatus(); // Call base class method
        Console.WriteLine("Tracking Number: " + TrackingNumber);
        Console.WriteLine("Status: Order Shipped");
    }
}

// DeliveredOrder extends ShippedOrder
class DeliveredOrder : ShippedOrder {
    public string DeliveryDate { get; set; } // Delivery date

    public override void GetOrderStatus() {
        base.GetOrderStatus(); // Call parent class method
        Console.WriteLine("Delivery Date: " + DeliveryDate);
        Console.WriteLine("Status: Order Delivered");
    }
}

class Program {
    public static void Main() {
        // Creating a DeliveredOrder object (which includes Order & ShippedOrder details)
        DeliveredOrder order1 = new DeliveredOrder {
            OrderID = 1,
            OrderDate = "31-05-2024",
            TrackingNumber = "TRK123456",
            DeliveryDate = "06-07-2024"
        };

        // Display order status at different stages
        order1.GetOrderStatus();
    }
}
