using System;
class Animal{
    public string Name{get;set;}
    public int Age{get;set;}

    public virtual void MakeSound(){
        Console.WriteLine("Animal makes a sound");
    }}

class Dog : Animal{
    public override void MakeSound(){
        Console.WriteLine( Name + " Barks");
    }

}
class Cat : Animal{
    public override void MakeSound(){
        Console.WriteLine(Name+ " Meows");
    } 
}
class Bird : Animal{
    public override void MakeSound(){
        Console.WriteLine(Name +" Chirps");
    }
}

class Program{
    public static void Main(string []args){
        Animal animal; // Base class Reference

        //creating Dog Object 
        animal = new Dog {Name = "buddy" , Age = 3};
        animal.MakeSound(); //call dog MakeSound method

        
        //creating Cat Object 
        animal = new Cat {Name = "billy" , Age = 5};
        animal.MakeSound(); //call cat MakeSound method

        //creating Bird Object 
        animal = new Bird {Name = "Chippy" , Age = 1};
        animal.MakeSound(); //call Bird MakeSound method
    }
}
