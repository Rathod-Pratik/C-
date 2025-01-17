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
class Dog : Animal
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

        // Access methods from the derived class
        myDog.Bark();
    }
}
