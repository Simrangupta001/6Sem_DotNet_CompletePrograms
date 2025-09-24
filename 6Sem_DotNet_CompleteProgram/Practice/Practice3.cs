using System;

namespace CompleteProgram
{
    class Practice3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Practice 3: Simple Calculator ===");

            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator (+, -, *, /): ");
            char op = Console.ReadLine()[0];

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        Console.WriteLine("Error: Division by zero not allowed!");
                    break;
                default:
                    Console.WriteLine("Invalid operator!");
                    break;
            }

            Console.WriteLine($"\nResult: {num1} {op} {num2} = {result}");
        }
    }
}
