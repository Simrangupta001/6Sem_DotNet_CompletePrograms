
using System;

namespace CompleteProgram
{
    // MathOperations class demonstrates methods in OOP style
    class MathOperations
    {
        // Method to calculate factorial
        public long Factorial(int n)
        {
            long fact = 1;
            for (int i = 1; i <= n; i++)
                fact *= i;
            return fact;
        }

        // Method to check if number is prime
        public bool IsPrime(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }

    class Practice5
    {
        static void Main(string[] args)
        {
            MathOperations math = new MathOperations();

            Console.WriteLine("=== Practice 5: Methods in OOP Style ===");
            Console.WriteLine("1. Find Factorial");
            Console.WriteLine("2. Check Prime");
            Console.Write("Choose option (1/2): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine($"Factorial of {num} = {math.Factorial(num)}");
            }
            else if (choice == 2)
            {
                Console.WriteLine(math.IsPrime(num) ? $"{num} is Prime." : $"{num} is Not Prime.");
            }
            else
            {
                Console.WriteLine("Invalid Choice!");
            }
        }
    }
}
    class MathOperations
    {
        // Method to calculate factorial
        public long Factorial(int n)
        {
            long fact = 1;
            for (int i = 1; i <= n; i++)
                fact *= i;
            return fact;
        }

        // Method to check if number is prime
        public bool IsPrime(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }

    class Practice5
    {
        static void Main(string[] args)
        {
            MathOperations math = new MathOperations();

            Console.WriteLine("=== Practice 5: Methods in OOP Style ===");
            Console.WriteLine("1. Find Factorial");
            Console.WriteLine("2. Check Prime");
            Console.Write("Choose option (1/2): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine($"Factorial of {num} = {math.Factorial(num)}");
            }
            else if (choice == 2)
            {
                Console.WriteLine(math.IsPrime(num) ? $"{num} is Prime." : $"{num} is Not Prime.");
            }
            else
            {
                Console.WriteLine("Invalid Choice!");
            }
        }
    }
}
```
