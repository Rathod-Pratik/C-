using System;

class Program
{
    static void Main()
    {
        //If statement
        int number = 10;
        if (number > 5)
        {
            Console.WriteLine("The number is greater than 5.");
        }

        //If else statement
        int number = 4;
        if (number > 5)
        {
            Console.WriteLine("The number is greater than 5.");
        }
        else
        {
            Console.WriteLine("The number is 5 or less.");
        }


        //if else ledder statment
        int number = 15;

        if (number < 5)
        {
            Console.WriteLine("The number is less than 5.");
        }
        else if (number >= 5 && number <= 10)
        {
            Console.WriteLine("The number is between 5 and 10.");
        }
        else if (number > 10 && number <= 20)
        {
            Console.WriteLine("The number is between 11 and 20.");
        }
        else
        {
            Console.WriteLine("The number is greater than 20.");
        }

        //Nested If else Statement
        int number = 8;

        if (number > 0)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is positive and even.");
            }
            else
            {
                Console.WriteLine("The number is positive and odd.");
            }
        }
        else
        {
            Console.WriteLine("The number is not positive.");
        }

        //Switch Case Statement
        int day = 3;

        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid day.");
                break;
        }
    }
}
