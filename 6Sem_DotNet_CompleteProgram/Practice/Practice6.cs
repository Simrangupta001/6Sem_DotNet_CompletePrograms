using System;

namespace CompleteProgram
{
    // Define a Student class
    class Student
    {
        public string Name { get; set; }
        public int Roll { get; set; }
        public double Marks { get; set; }

        // Method to display student info
        public void Display()
        {
            Console.WriteLine($"Roll: {Roll}, Name: {Name}, Marks: {Marks}");
        }
    }

    class Practice6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Practice 6: Classes & Objects ===");

            Console.Write("Enter number of students: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Student[] students = new Student[n];

            // Input loop
            for (int i = 0; i < n; i++)
            {
                students[i] = new Student();

                Console.Write($"\nEnter roll for student {i + 1}: ");
                students[i].Roll = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter name: ");
                students[i].Name = Console.ReadLine();

                Console.Write("Enter marks: ");
                students[i].Marks = Convert.ToDouble(Console.ReadLine());
            }

            // Output loop
            Console.WriteLine("\n--- Student Details ---");
            foreach (var s in students)
            {
                s.Display();
            }
        }
    }
}
