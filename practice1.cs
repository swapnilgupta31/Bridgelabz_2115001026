using System;

class BaseClass {
    public int PublicValue = 10;          // Accessible everywhere
    protected int ProtectedValue = 20;   // Accessible in derived classes
    private int PrivateValue = 30;       // Accessible only in this class
    internal int InternalValue = 40;     // Accessible within the same assembly

    public void DisplayValues() {
        Console.WriteLine($"Public: {PublicValue}, Protected: {ProtectedValue}, Private: {PrivateValue}, Internal: {InternalValue}");
    }
}

class DerivedClass : BaseClass {
    public void ShowProtected() {
        Console.WriteLine($"Protected value from base class: {ProtectedValue}");
    }
}

class Program {
    static void Main() {
        BaseClass baseObj = new BaseClass();
        baseObj.DisplayValues();

        DerivedClass derivedObj = new DerivedClass();
        derivedObj.ShowProtected();

        Console.WriteLine($"Internal value: {baseObj.InternalValue}");
        Console.WriteLine($"Public value: {baseObj.PublicValue}");
    }
}
