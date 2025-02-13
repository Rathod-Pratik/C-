using System;


namespace HelloWorldApp
{
    delegate void MyDelegate(string message);

    class Program
    {
        static void DisplayMessage(string msg)
        {
            Console.WriteLine("Message: " + msg);
        }

        static void Main(string[] args)
        {
            MyDelegate del =new MyDelegate(DisplayMessage);
            del("Mohit botiyo");
            Console.ReadLine();
        }
    }
}