using System;

// Abstract class
abstract class Shape
{
    // Abstract method (no implementation)
    public abstract double GetArea();

    // Concrete method (has implementation)
    public void Display()
    {
        Console.WriteLine("This is a shape.");
    }
}

// Derived class 1
class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    // Override the abstract method
    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

// Derived class 2
class Rectangle : Shape
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    // Override the abstract method
    public override double GetArea()
    {
        return width * height;
    }
}

class Program
{
    static void Main()
    {
        // Create instances of derived classes
        Shape circle = new Circle(5);
        Shape rectangle = new Rectangle(4, 6);

        // Call methods
        circle.Display(); // Output: This is a shape.
        Console.WriteLine("Area of Circle: " + circle.GetArea()); // Output: 78.54

        rectangle.Display(); // Output: This is a shape.
        Console.WriteLine("Area of Rectangle: " + rectangle.GetArea()); // Output: 24
    }
}
