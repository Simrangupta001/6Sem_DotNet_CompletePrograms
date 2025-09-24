using System;

namespace CompleteProgram
{
    // Interface definition
    interface IShape
    {
        double Area();
        double Perimeter();
    }

    // CircleShape class implementing IShape
    class CircleShape : IShape
    {
        public double Radius { get; set; }

        public double Area() => Math.PI * Radius * Radius;

        public double Perimeter() => 2 * Math.PI * Radius;
    }

    // RectangleShape class implementing IShape
    class RectangleShape : IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public double Area() => Length * Width;

        public double Perimeter() => 2 * (Length + Width);
    }

    class Practice10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Practice 10: Interfaces ===");

            // CircleShape
            CircleShape c = new CircleShape();
            Console.Write("Enter radius of circle: ");
            c.Radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Circle Area: {c.Area():F2}");
            Console.WriteLine($"Circle Perimeter: {c.Perimeter():F2}");

            // RectangleShape
            RectangleShape r = new RectangleShape();
            Console.Write("\nEnter length of rectangle: ");
            r.Length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter width of rectangle: ");
            r.Width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Rectangle Area: {r.Area():F2}");
            Console.WriteLine($"Rectangle Perimeter: {r.Perimeter():F2}");
        }
    }
}
