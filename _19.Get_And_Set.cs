using System;


namespace HelloWorldApp
{
    class student
    {
        string code, name;
        int age;

        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public override string ToString()
        {
            return "\nCode :"+Code + "\nName :"+ Name + "\nAge :"+ Age;
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.Code = "Java";
            s.Name = "Mohit";
            s.Age = 21;
            Console.WriteLine("Student info is :" + s);
            Console.ReadLine();
        }
    }
}
