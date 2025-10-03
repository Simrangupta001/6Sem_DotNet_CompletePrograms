using System;

namespace CompleteProgram
{
    class Practice2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Practice 2 ===");
            Console.Write("Enter your   name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your current age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nHello {name}, you are {age} years old!");
        }
    }
}
