using System;

class Calculator
{
    // Method to add two integers
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Overloaded method to add three integers
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    // Overloaded method to add two doubles
    public double Add(double a, double b)
    {
        return a + b;
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        // Call the method with two integers
        Console.WriteLine("Sum of 2 and 3: " + calc.Add(2, 3));

        // Call the method with three integers
        Console.WriteLine("Sum of 2, 3, and 4: " + calc.Add(2, 3, 4));

        // Call the method with two doubles
        Console.WriteLine("Sum of 2.5 and 3.5: " + calc.Add(2.5, 3.5));
    }
}
