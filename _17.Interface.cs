using System;


namespace HelloWorldApp
{
   
    class Program
    {
        public interface a
        {
            void m1();
        }
        public interface b
        {
            void mz();
        }
        public class c : a, b
        {
           public void m1()
            {
                Console.WriteLine("This is message of m1");
            }
           public void mz()
            {
                Console.WriteLine("This is message of mz");
            }
        }

        static void Main(string[] args)
        {
            c a = new c();
            a.m1();
            a.mz();
            Console.ReadLine();
        }
    }
}
