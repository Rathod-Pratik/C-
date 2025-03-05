using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Stack stack = new Stack();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        stack.Pop(); // Remove the top item

        while (stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());
        }
    }
}