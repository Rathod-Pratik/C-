using System;

// Namespace declaration 
namespace HelloWorldApp
{
    // Class declaration 
    class Program
    {
        // Default Constructor
        public Program()
        {
            Console.WriteLine("This is the default constructor");
        }

        // Parameterized Constructor
        public Program(int a, int b)
        {
            Console.WriteLine("Sum of two numbers is: " + (a + b));
        }

        // Destructor
        ~Program()
        {
            Console.WriteLine("Destructor is called. Cleaning up resources...");
        }

        // Main Method 
        static void Main(string[] args)
        {
            // Creating objects
            Program program1 = new Program();
            Program program2 = new Program(5, 10);

            // Forcing Garbage Collection (Not recommended in real-world use)
            program1 = null; // Dereferencing object
            program2 = null;
            GC.Collect();  // Force garbage collection (Calls destructor)
            GC.WaitForPendingFinalizers();  // Ensures destructor executes

            Console.WriteLine("End of Main method");
            Console.ReadLine();  // Wait for user input before closing
        }
    }
}
