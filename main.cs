using System;

namespace Hello{
    class Program{
        public static void Main(string[] args)
        {
            string name;
            int age;

            System.Console.WriteLine("Enter your name");
            name = System.Console.ReadLine();
            System.Console.WriteLine("Enter your age");
            age = int.Parse(System.Console.ReadLine());
            
            System.Console.WriteLine("Welcome {0}, age is {1}",name,age);
            Console.WriteLine();

        }
    }
}