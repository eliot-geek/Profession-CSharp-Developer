using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less04CatProgram
{
    /// <summary>
    /// Represents a Cat with properties such as Nickname, Breed, and Weight.
    /// Contains methods for playing, sleeping, eating, and making a cat sound.
    /// </summary>
    internal class Cat
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
    }
}
