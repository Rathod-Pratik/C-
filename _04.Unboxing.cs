using System;

// namespace declaration 
namespace HelloWorldApp
{

    // Class declaration 
    class Hello
    {

        // Main Method 
        static void Main(string[] args)
        {
            double num = 100;
            object iobj = num;

            int j=(int)(double)iobj;

            Console.WriteLine("Value of Number is :"+num.GetType());
            Console.WriteLine("Value of j is :"+ j.GetType());
            Console.ReadLine();

        }
    }
}