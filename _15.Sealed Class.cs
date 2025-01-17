using System;
//Sealed classes cannot be inherited.
sealed class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();
        Console.WriteLine("Sum: " + calc.Add(5, 3));        // Output: Sum: 8
        Console.WriteLine("Difference: " + calc.Subtract(5, 3)); // Output: Difference: 2
    }
}
