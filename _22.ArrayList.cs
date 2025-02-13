using System;
using System.Collections;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(1);
            al.Add(2);
            al.Add(3);

            al.Remove(1);
            foreach(var item in al)
            {
                Console.WriteLine(item);
            }

            al.Clear();
            Console.WriteLine("After Clear");
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}