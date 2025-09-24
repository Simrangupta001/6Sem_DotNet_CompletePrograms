using System;

namespace CompleteProgram
{
    // Base class
    class Shape
    {
        // Virtual method → can be overridden in derived classes
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape...");
        }
    }

    // Derived class 1
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle ⭕");
        }
    }

    // Derived class 2
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle ▭");
        }
    }

    class Practice8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Practice 8: Polymorphism (Method Overriding) ===");

            // Base class reference can hold derived objects
            Shape s1 = new Circle();
            Shape s2 = new Rectangle();

            s1.Draw();   // Calls Circle.Draw()
            s2.Draw();   // Calls Rectangle.Draw()

            // Array of shapes
            Shape[] shapes = { new Circle(), new Rectangle(), new Shape() };

            Console.WriteLine("\n--- Drawing all shapes in array ---");
            foreach (var shape in shapes)
            {
                shape.Draw(); // Polymorphism in action
            }
        }
    }
}
