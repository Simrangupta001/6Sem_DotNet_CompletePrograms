using System;

namespace CompleteProgram
{
    class Practice4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Practice 4: Student Marks ===");

            Console.Write("Enter number of students: ");
            int n = Convert.ToInt32(Console.ReadLine());

            string[] names = new string[n];
            int[] marks = new int[n];

            // Input loop
            for (int i = 0; i < n; i++)
            {
                Console.Write($"\nEnter name of student {i + 1}: ");
                names[i] = Console.ReadLine();

                Console.Write($"Enter marks of {names[i]}: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Output loop
            Console.WriteLine("\n--- Student Marks List ---");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1}. {names[i]} → {marks[i]} marks");
            }

            // Calculate average
            double total = 0;
            for (int i = 0; i < n; i++)
                total += marks[i];

            double average = total / n;
            Console.WriteLine($"\nClass Average = {average:F2}");
        }
    }
}
