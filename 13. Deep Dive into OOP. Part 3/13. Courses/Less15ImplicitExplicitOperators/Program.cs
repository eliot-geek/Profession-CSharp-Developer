using System;

namespace Less15ImplicitExplicitOperators
{
    /// <summary>
    /// Represents a cat.
    /// </summary>
    class Cat
    {
        /// <summary>
        /// Gets or sets the name of the cat.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Defines an explicit conversion from Animal to Cat.
        /// </summary>
        /// <param name="cat">The animal to convert.</param>
        /// <returns>A new instance of Cat with the name set to the breed of the animal.</returns>
        public static explicit operator Cat(Animal cat)
        {
            return new Cat { Name = cat.Breed };
        }
    }

    /// <summary>
    /// Represents an animal.
    /// </summary>
    class Animal
    {
        /// <summary>
        /// Gets or sets the breed of the animal.
        /// </summary>
        public string Breed { get; set; }

        /// <summary>
        /// Defines an implicit conversion from Cat to Animal.
        /// </summary>
        /// <param name="cat">The cat to convert.</param>
        /// <returns>A new instance of Animal with the breed set to the name of the cat.</returns>
        public static implicit operator Animal(Cat cat)
        {
            return new Animal { Breed = cat.Name };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat { Name = "Barshik" };
            Console.WriteLine($"Cat.Name = {cat.Name}");

            // Implicit operator
            Animal animal = cat;
            Console.WriteLine($"Animal.Breed = {animal.Breed}");

            // Explicit operator
            cat = (Cat)animal;
            Console.WriteLine($"Cat.Name = {cat.Name}");
        }
    }
}
