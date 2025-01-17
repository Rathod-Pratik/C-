using System;

class Animal
{
    // Virtual method in the base class
    public virtual void Speak()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

class Dog : Animal
{
    // Overriding the Speak method in the derived class
    public override void Speak()
    {
        Console.WriteLine("The dog barks.");
    }
}

class Cat : Animal
{
    // Overriding the Speak method in the derived class
    public override void Speak()
    {
        Console.WriteLine("The cat meows.");
    }
}

class Program
{
    static void Main()
    {
        Animal myAnimal;

        // Runtime polymorphism
        myAnimal = new Dog();
        myAnimal.Speak(); // Output: The dog barks.

        myAnimal = new Cat();
        myAnimal.Speak(); // Output: The cat meows.
    }
}
