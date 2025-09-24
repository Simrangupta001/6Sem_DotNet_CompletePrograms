using System;

namespace CompleteProgram
{
    class Practice5
    {
        // Method to calculate factorial
        static long Factorial(int n)
        {
            long fact = 1;
            for (int i = 1; i <= n; i++)
                fact *= i;
            return fact;
        }

        // Method to check if number is prime
        static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== Practice 5: Methods Demo ===");
            Console.WriteLine("1. Find Factorial");
            Console.WriteLine("2. Check Prime");
            Console.Write("Choose option (1/2): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine($"Factorial of {num} = {Factorial(num)}");
            }
            else if (choice == 2)
            {
                if (IsPrime(num))
                    Console.WriteLine($"{num} is Prime.");
                else
                    Console.WriteLine($"{num} is Not Prime.");
            }
            else
            {
                Console.WriteLine("Invalid Choice!");
            }
        }
    }
}
