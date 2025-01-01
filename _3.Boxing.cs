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
            int num = 100;
            object iobj = num;
            num = 200;
            Console.WriteLine("Value of Number is :"+num);
            Console.WriteLine("Value of iobj is :"+iobj);
            Console.ReadLine();

        }
    }
}