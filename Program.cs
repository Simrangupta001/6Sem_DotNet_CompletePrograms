using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Create a list of integers
        List<int> numbers = new List<int> { 9, 3, 5, 1, 7, 2 };

        // LINQ query to sort in ascending order
        var sortedNumbers = from n in numbers
                            orderby n
                            select n;

        Console.WriteLine("Sorted numbers in ascending order:");

        foreach (int num in sortedNumbers)
        {
            Console.Write(num + " ");
        }
    }
}
