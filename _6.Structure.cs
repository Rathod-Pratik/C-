using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vatsal
{
    class Program
    {
        static void Main(string[] args)
        {
            Result std1;
            Console.Write("Enter the marks english");
            std1.english = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the marks Maths");
            std1.math = Convert.ToInt32(Console.ReadLine());
            int total = std1.math + std1.english;
            Console.WriteLine("Your Total marks are :" + total);
            std1.percentage=(double)total / 2;
            Console.WriteLine("Your percentage is " + std1.percentage);



            if (std1.percentage >= 30 && std1.percentage <= 50)
                {

                std1.grade = 'C';

            }
                else if (std1.percentage >= 50 && std1.percentage <= 75)
            {
                std1.grade = 'B';

            }
            else if (std1.percentage >= 75 && std1.percentage <= 100)
            {
                std1.grade = 'A';

            }
            else
            {
                Console.WriteLine("You are fail");
                std1.grade = 'F';

            }

            Console.WriteLine("Your Marks in maths is :" + std1.math);
            Console.WriteLine("Your Marks in English is :" + std1.english);
            Console.WriteLine("Your percentge :" + std1.percentage);
            Console.WriteLine("Your grade :" + std1.grade);

            Console.ReadLine();
        }
        struct Result
        {
            public int math;
            public int english;
            public double percentage;
            public char grade;
        }
    }
}
