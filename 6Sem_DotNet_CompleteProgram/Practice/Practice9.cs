using System;

namespace CompleteProgram
{
    // Abstract base class
    abstract class Animal
    {
        public string Name { get; set; }

        // Abstract method → must be implemented in derived classes
        public abstract void Speak();

        // Normal method → can be used directly
        public void ShowInfo()
        {
            Console.WriteLine($"Animal Name: {Name}");
        }
    }

    // Derived class Dog
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Woof! Woof!");
        }
    }

    // Derived class Cat
    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Meow! Meow!");
        }
    }

    class Practice9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Practice 9: Abstraction with Abstract Classes ===");

            // Create Dog object
            Animal dog = new Dog { Name = "Buddy" };
            dog.ShowInfo();
            dog.Speak();

            // Create Cat object
            Animal cat = new Cat { Name = "Kitty" };
            cat.ShowInfo();
            cat.Speak();

            // Array of abstract type references
            Animal[] animals = { dog, cat };
            Console.WriteLine("\n--- Animal Sounds ---");
            foreach (var a in animals)
            {
                a.Speak(); // Polymorphic behavior
            }
        }
    }
}
