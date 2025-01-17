using System;

// Base class
class Animal
{
    public void Eat()
    {
        Console.WriteLine("This animal eats food.");
    }
}

// Derived class
class Mammal : Animal
{
    public void Walk()
    {
        Console.WriteLine("This mammal walks on four legs.");
    }
}

// Another derived class (inherits from Mammal)
class Dog : Mammal
{
    public void Bark()
    {
        Console.WriteLine("The dog barks.");
    }
}

class Program
{
    static void Main()
    {
        Dog myDog = new Dog();

        // Access methods from the base class
        myDog.Eat();

        // Access methods from the intermediate class
        myDog.Walk();

        // Access methods from the derived class
        myDog.Bark();
    }
}
