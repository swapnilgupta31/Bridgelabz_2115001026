using System;

// Base class: Person
class Person {
    public string Name { get; set; }
    public int Id { get; set; }

    public void DisplayPersonInfo() {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("ID: " + Id);
    }
}

// Interface: Worker
interface Worker {
    void PerformDuties();
}

// Subclass: Chef (inherits from Person, implements Worker)
class Chef : Person, Worker {
    public void PerformDuties() {
        Console.WriteLine("Role: Chef");
        Console.WriteLine("Duties: Preparing meals, managing kitchen.");
    }
}

// Subclass: Waiter (inherits from Person, implements Worker)
class Waiter : Person, Worker {
    public void PerformDuties() {
        Console.WriteLine("Role: Waiter");
        Console.WriteLine("Duties: Serving customers, taking orders.");
    }
}
// Main program
class Program {
    public static void Main(string[] args) {
        Chef chef = new Chef();
        chef.Name = "Gordon";
        chef.Id = 101;

        Waiter waiter = new Waiter();
        waiter.Name = "John";
        waiter.Id = 202;

        // Display details and duties
        chef.DisplayPersonInfo();
        chef.PerformDuties();
        Console.WriteLine();

        waiter.DisplayPersonInfo();
        waiter.PerformDuties();
    }
}
