using System;

namespace CompleteProgram
{
    // Base class
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void ShowPersonInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    // Derived class
    class Students : Person
    {
        public int RollNO { get; set; }
        public double MarksObtain { get; set; }

        public void ShowStudentInfo()
        {
            // Call base class method
            ShowPersonInfo();
            Console.WriteLine($"Roll: {RollNO}, Marks: {MarksObtain}");
        }
    }

    class Practice7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Practice 7: Inheritance ===");

            Students s1 = new Students();

            Console.Write("Enter the student name: ");
            s1.Name = Console.ReadLine();

            Console.Write("Enter the age: ");
            s1.Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the roll: ");
            s1.RollNO = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the marks: ");
            s1.MarksObtain = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n--- Student Information ---");
            s1.ShowStudentInfo();
        }
    }
}
