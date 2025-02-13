using System;


namespace HelloWorldApp
{
    class Example
    {
        // Static variable (shared among all instances)
        public static int staticValue = 10;

        // Non-static variable (unique for each instance)
        public int nonStaticValue = 20;

        // Static method (can be accessed without creating an object)
        public static void StaticMethod()
        {
            Console.WriteLine("This is a static method.");
            Console.WriteLine("Static Value: " + staticValue);
        }

        // Non-static method (requires an object to access)
        public void NonStaticMethod()
        {
            Console.WriteLine("This is a non-static method.");
            Console.WriteLine("Non-Static Value: " + nonStaticValue);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Accessing static member directly using class name
            Console.WriteLine("Accessing Static Member: " + Example.staticValue);
            Example.StaticMethod();

            // Creating object to access non-static members
            Example obj = new Example();
            Console.WriteLine("Accessing Non-Static Member: " + obj.nonStaticValue);
            obj.NonStaticMethod();
            Console.ReadLine();
        }
    }
}
