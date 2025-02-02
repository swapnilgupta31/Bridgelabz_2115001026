using System;

class Person {
    string name;
    int age;

    // Parameterized Constructor
    public Person(string name, int age) {
        this.name = name;
        this.age = age;
    }

    // Copy Constructor
    public Person(Person p) {
        this.name = p.name;
        this.age = p.age;
    }

    public void Display() {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

class Program {
    static void Main() {
        Person p1 = new Person("Alice", 25); // Original Person
        Person p2 = new Person(p1); // Copy Constructor

        Console.WriteLine("Original Person:");
        p1.Display();
        Console.WriteLine("\nCopied Person:");
        p2.Display();
    }
}
