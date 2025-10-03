
using System;

namespace CompleteProgram
{
    // Base class
    class Animal
    {
        // Virtual method → can be overridden in derived classes
        public virtual void Speak()
        {
            Console.WriteLine("Animal makes a sound...");
        }
    }

    // Derived class 1
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog says: Woof! 🐶");
        }
    }

    // Derived class 2
    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat says: Meow! 🐱");
        }
    }

    // Derived class 3
    class Bird : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Bird says: Chirp! 🐦");
        }
    }

    class Practice8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Practice 8: Polymorphism (Method Overriding) ===");

            // Base class reference can hold derived objects
            Animal a1 = new Dog();
            Animal a2 = new Cat();
            Animal a3 = new Bird();

            a1.Speak();   // Calls Dog.Speak()
            a2.Speak();   // Calls Cat.Speak()
            a3.Speak();   // Calls Bird.Speak()

            // Array of animals
            Animal[] animals = { new Dog(), new Cat(), new Bird(), new Animal() };

            Console.WriteLine("\n--- All animals speak ---");
            foreach (var animal in animals)
            {
                animal.Speak(); // Polymorphism in action
            }
        }
    }
}

