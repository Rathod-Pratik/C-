using System;

class Program
{
    unsafe static void Main()
    {
        int num = 10;

        // Declare a pointer to the integer
        int* p = &num;

        Console.WriteLine("Value of num: " + num);
        Console.WriteLine("Address of num: " + (long)p);
        Console.WriteLine("Value at the address: " + *p);

        // Modify the value using the pointer
        *p = 20;

        Console.WriteLine("Modified value of num: " + num);
    }
}
