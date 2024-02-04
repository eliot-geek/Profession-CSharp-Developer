using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less05CatBetter
{
    /// <summary>
    /// Represents a Cat with properties such as Nickname, Breed, and Weight.
    /// Contains methods for playing, sleeping, eating, and making a cat sound.
    /// Implements the IComparable interface for custom comparison logic.
    /// </summary>
    
    // internal class Cat : IComparable       // public int CompareTo(object obj)
    internal class Cat : IComparable<Cat>       // public int CompareTo(Cat other)
    {
        /// <summary>
        /// Stores the breed of the cat.
        /// </summary>
        private string breed;

        /// <summary>
        /// Stores the weight of the cat.
        /// </summary>
        private int weight;

        /// <summary>
        /// Gets the weight of the cat.
        /// </summary>
        private int Weight { get { return this.weight; } }

        /// <summary>
        /// Gets or sets the nickname of the cat.
        /// </summary>
        public string Nickname { get; set; }

        /// <summary>
        /// Gets the breed of the cat.
        /// </summary>
        public string Breed { get { return "Breed: " + this.breed; } }

        /// <summary>
        /// Initializes a new instance of the Cat class.
        /// </summary>
        /// <param name="Nickname">The nickname of the cat.</param>
        /// <param name="Breed">The breed of the cat.</param>
        /// <param name="Weight">The weight of the cat.</param>
        public Cat(string Nickname, string Breed, int Weight)
        {
            this.Nickname = Nickname;
            this.breed = Breed;
            this.weight = Weight;
        }

        /// <summary>
        /// Simulates the logic of the cat playing.
        /// </summary>
        public void ToPlay() { Console.WriteLine($"{this.Nickname} plays..."); }

        /// <summary>
        /// Simulates the logic of the cat sleeping.
        /// </summary>
        public void ToSleep() { Console.WriteLine($"{this.Nickname} sleeping..."); }

        /// <summary>
        /// Simulates the logic of the cat eating.
        /// </summary>
        public void ToEat() { Console.WriteLine($"{this.Nickname} eating..."); }

        /// <summary>
        /// Simulates the cat making a sound (MEW).
        /// </summary>
        public void ToMew() { Console.WriteLine($"Mew!"); }

        /// <summary>
        /// Overrides the default ToString method to provide a formatted string representation of the cat.
        /// </summary>
        public override string ToString()
        {
            return $"{Nickname,10} {breed,10} {Weight,3}";
        }

        #region Object obj - use this (internal class Cat : IComparable)

        /// <summary>
        /// Compares the current cat with another object based on their weights.
        /// Implements the IComparable interface method.
        /// </summary>
        /// <param name="obj">The object to compare with the current cat.</param>
        /// <returns>
        ///   1 if the current cat's weight is greater,
        ///   -1 if less,
        ///   0 if equal.
        /// </returns>
        public int CompareTo(object obj)
        {
            var other = (Cat)obj;
            if (this.weight > other.weight) 
                return 1;
            else if (this.weight < other.weight) 
                return -1;
            else 
                return 0;
        }

        #endregion


        #region Cat other - use this (internal class Cat : IComparable<Cat>)
        
        /// <summary>
        /// Compares the current cat with another cat based on their weights.
        /// </summary>
        /// <param name="other">The cat to compare with the current cat.</param>
        /// <returns>1 if the current cat's weight is greater, -1 if less, 0 if equal.</returns>
        public int CompareTo(Cat other)
        {
            if (this.weight > other.weight) 
                return 1;
            else if (this.weight < other.weight) 
                return -1;
            else 
                return 0;
        }

        #endregion
    }
}
