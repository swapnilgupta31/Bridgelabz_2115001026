using System;

// Node Class: Represents an Item
class ItemNode {
    public int itemId;
    public string itemName;
    public int quantity;
    public double price;
    public ItemNode next;

    // Constructor
    public ItemNode(int itemId, string itemName, int quantity, double price) {
        this.itemId = itemId;
        this.itemName = itemName;
        this.quantity = quantity;
        this.price = price;
        this.next = null;
    }
}

// Singly Linked List Class
class InventoryManager {
    private ItemNode head = null;

    // Add Item at Beginning
    public void AddAtBeginning(int itemId, string itemName, int quantity, double price) {
        ItemNode newItem = new ItemNode(itemId, itemName, quantity, price);
        newItem.next = head;
        head = newItem;
    }

    // Add Item at End
    public void AddAtEnd(int itemId, string itemName, int quantity, double price) {
        ItemNode newItem = new ItemNode(itemId, itemName, quantity, price);
        if (head == null) {
            head = newItem;
            return;
        }
        ItemNode temp = head;
        while (temp.next != null) {
            temp = temp.next;
        }
        temp.next = newItem;
    }

    // Add Item at Specific Position (1-based index)
    public void AddAtPosition(int position, int itemId, string itemName, int quantity, double price) {
        if (position < 1) {
            Console.WriteLine("Invalid position");
            return;
        }
        if (position == 1) {
            AddAtBeginning(itemId, itemName, quantity, price);
            return;
        }
        ItemNode newItem = new ItemNode(itemId, itemName, quantity, price);
        ItemNode temp = head;
        for (int i = 1; temp != null && i < position - 1; i++) {
            temp = temp.next;
        }
        if (temp == null) {
            Console.WriteLine("Position out of bounds");
            return;
        }
        newItem.next = temp.next;
        temp.next = newItem;
    }

    // Remove Item by Item ID
    public void RemoveByItemId(int itemId) {
        if (head == null) {
            Console.WriteLine("Inventory is empty");
            return;
        }
        if (head.itemId == itemId) {
            head = head.next;
            return;
        }
        ItemNode temp = head;
        while (temp.next != null && temp.next.itemId != itemId) {
            temp = temp.next;
        }
        if (temp.next == null) {
            Console.WriteLine("Item not found");
            return;
        }
        temp.next = temp.next.next;
    }

    // Update Item Quantity by Item ID
    public void UpdateQuantity(int itemId, int newQuantity) {
        ItemNode temp = head;
        while (temp != null) {
            if (temp.itemId == itemId) {
                temp.quantity = newQuantity;
                return;
            }
            temp = temp.next;
        }
        Console.WriteLine("Item not found");
    }

    // Search Item by Item ID
    public void SearchByItemId(int itemId) {
        ItemNode temp = head;
        while (temp != null) {
            if (temp.itemId == itemId) {
                Console.WriteLine("ID: " + temp.itemId + ", Name: " + temp.itemName +
                                  ", Quantity: " + temp.quantity + ", Price: " + temp.price);
                return;
            }
            temp = temp.next;
        }
        Console.WriteLine("Item not found");
    }

    // Search Item by Item Name
    public void SearchByItemName(string itemName) {
        ItemNode temp = head;
        bool found = false;
        while (temp != null) {
            if (temp.itemName.Equals(itemName, StringComparison.OrdinalIgnoreCase)) {
                Console.WriteLine("ID: " + temp.itemId + ", Quantity: " + temp.quantity + ", Price: " + temp.price);
                found = true;
            }
            temp = temp.next;
        }
        if (!found) Console.WriteLine("Item not found");
    }

    // Calculate and Display Total Inventory Value
    public void CalculateTotalValue() {
        double totalValue = 0;
        ItemNode temp = head;
        while (temp != null) {
            totalValue += temp.quantity * temp.price;
            temp = temp.next;
        }
        Console.WriteLine("Total Inventory Value: " + totalValue);
    }

    // Sort Inventory by Item Name (Ascending Order)
    public void SortByItemName() {
        if (head == null || head.next == null) return;

        ItemNode current, index;
        string tempName;
        int tempId, tempQty;
        double tempPrice;

        for (current = head; current != null; current = current.next) {
            for (index = current.next; index != null; index = index.next) {
                if (string.Compare(current.itemName, index.itemName, StringComparison.OrdinalIgnoreCase) > 0) {
                    tempName = current.itemName;
                    tempId = current.itemId;
                    tempQty = current.quantity;
                    tempPrice = current.price;

                    current.itemName = index.itemName;
                    current.itemId = index.itemId;
                    current.quantity = index.quantity;
                    current.price = index.price;

                    index.itemName = tempName;
                    index.itemId = tempId;
                    index.quantity = tempQty;
                    index.price = tempPrice;
                }
            }
        }
    }

    // Sort Inventory by Price (Ascending Order)
    public void SortByPrice() {
        if (head == null || head.next == null) return;

        ItemNode current, index;
        string tempName;
        int tempId, tempQty;
        double tempPrice;

        for (current = head; current != null; current = current.next) {
            for (index = current.next; index != null; index = index.next) {
                if (current.price > index.price) {
                    tempName = current.itemName;
                    tempId = current.itemId;
                    tempQty = current.quantity;
                    tempPrice = current.price;

                    current.itemName = index.itemName;
                    current.itemId = index.itemId;
                    current.quantity = index.quantity;
                    current.price = index.price;

                    index.itemName = tempName;
                    index.itemId = tempId;
                    index.quantity = tempQty;
                    index.price = tempPrice;
                }
            }
        }
    }

    // Display All Items
    public void DisplayInventory() {
        if (head == null) {
            Console.WriteLine("Inventory is empty");
            return;
        }
        ItemNode temp = head;
        while (temp != null) {
            Console.WriteLine("ID: " + temp.itemId + ", Name: " + temp.itemName +
                              ", Quantity: " + temp.quantity + ", Price: " + temp.price);
            temp = temp.next;
        }
    }
}

// Main Program
class Program {
    static void Main() {
        InventoryManager inventory = new InventoryManager();

        // Adding items
        inventory.AddAtBeginning(101, "Laptop", 5, 750.50);
        inventory.AddAtEnd(102, "Mouse", 20, 15.99);
        inventory.AddAtPosition(2, 103, "Keyboard", 10, 25.50);

        // Display inventory
        Console.WriteLine("Inventory Items:");
        inventory.DisplayInventory();

        // Update quantity
        Console.WriteLine("\nUpdating quantity of Item ID 103:");
        inventory.UpdateQuantity(103, 15);
        inventory.DisplayInventory();

        // Search for an item
        Console.WriteLine("\nSearching for Item ID 102:");
        inventory.SearchByItemId(102);

        // Calculate total inventory value
        Console.WriteLine("\nCalculating Total Inventory Value:");
        inventory.CalculateTotalValue();

        // Sort by price and display
        Console.WriteLine("\nSorting Inventory by Price:");
        inventory.SortByPrice();
        inventory.DisplayInventory();
    }
}
