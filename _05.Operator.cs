using System;

namespace OperatorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arithmetic Operators
            int a = 10, b = 3;
            Console.WriteLine("Arithmetic Operators:");
            Console.WriteLine($"Addition: a + b = {a + b}");
            Console.WriteLine($"Subtraction: a - b = {a - b}");
            Console.WriteLine($"Multiplication: a * b = {a * b}");
            Console.WriteLine($"Division: a / b = {a / b}");
            Console.WriteLine($"Modulus: a % b = {a % b}");
            Console.WriteLine();

            // Relational Operators
            Console.WriteLine("Relational Operators:");
            Console.WriteLine($"a == b: {a == b}");
            Console.WriteLine($"a != b: {a != b}");
            Console.WriteLine($"a > b: {a > b}");
            Console.WriteLine($"a < b: {a < b}");
            Console.WriteLine($"a >= b: {a >= b}");
            Console.WriteLine($"a <= b: {a <= b}");
            Console.WriteLine();

            // Logical Operators
            bool x = true, y = false;
            Console.WriteLine("Logical Operators:");
            Console.WriteLine($"x && y: {x && y}");
            Console.WriteLine($"x || y: {x || y}");
            Console.WriteLine($"!x: {!x}");
            Console.WriteLine();

            // Bitwise Operators
            Console.WriteLine("Bitwise Operators:");
            Console.WriteLine($"a & b: {a & b}");  // Bitwise AND
            Console.WriteLine($"a | b: {a | b}");  // Bitwise OR
            Console.WriteLine($"a ^ b: {a ^ b}");  // Bitwise XOR
            Console.WriteLine($"~a: {~a}");        // Bitwise NOT
            Console.WriteLine($"a << 1: {a << 1}"); // Left shift
            Console.WriteLine($"a >> 1: {a >> 1}"); // Right shift
            Console.WriteLine();

            // Assignment Operators
            Console.WriteLine("Assignment Operators:");
            int c = a;  // Assign
            Console.WriteLine($"c = a: {c}");
            c += b;     // Add and assign
            Console.WriteLine($"c += b: {c}");
            c -= b;     // Subtract and assign
            Console.WriteLine($"c -= b: {c}");
            c *= b;     // Multiply and assign
            Console.WriteLine($"c *= b: {c}");
            c /= b;     // Divide and assign
            Console.WriteLine($"c /= b: {c}");
            c %= b;     // Modulus and assign
            Console.WriteLine($"c %= b: {c}");
            Console.WriteLine();

            // Unary Operators
            Console.WriteLine("Unary Operators:");
            int d = +a; // Unary plus
            Console.WriteLine($"+a: {d}");
            d = -a;     // Unary minus
            Console.WriteLine($"-a: {d}");
            d = ++a;    // Pre-increment
            Console.WriteLine($"++a: {d}");
            d = --a;    // Pre-decrement
            Console.WriteLine($"--a: {d}");
            Console.WriteLine();

            // Conditional/Ternary Operator
            Console.WriteLine("Ternary Operator:");
            string result = (a > b) ? "a is greater" : "b is greater";
            Console.WriteLine($"(a > b) ? \"a is greater\" : \"b is greater\": {result}");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
