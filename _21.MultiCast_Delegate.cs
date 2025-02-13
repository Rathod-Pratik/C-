using System;


namespace HelloWorldApp
{
    delegate void MyDelegate(string message);

    class Program
    {
        static void MethodOne(string msg)
        {
            Console.WriteLine("MethodOne: " + msg);
        }

        static void MethodTwo(string msg)
        {
            Console.WriteLine("MethodTwo: " + msg);
        }

        static void Main(string[] args)
        {
            MyDelegate del1 =new MyDelegate(MethodOne);
            MyDelegate del2 =new MyDelegate(MethodTwo);

            MyDelegate multiCast = del1 + del2;
            multiCast("Mohit botiyo");

            //Remove method
            multiCast -= MethodOne;

            multiCast("\nRathod Pratik");
            Console.ReadLine();
        }
    }
}
