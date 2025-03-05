using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Queue queue = new Queue();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        queue.Dequeue(); // Remove the front item

        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }
    }
}