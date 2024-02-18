using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less06LimitationsGenericsTypes
{
    /// <summary>
    /// Represents a cat.
    /// </summary>
    public class Cat
    {
        /// <summary>
        /// Initializes a new instance of the Cat class.
        /// </summary>
        public Cat()
        {

        }

        /// <summary>
        /// Initializes a new instance of the Cat class with the specified nickname and breed.
        /// </summary>
        /// <param name="Nickname">The nickname of the cat.</param>
        /// <param name="Breed">The breed of the cat.</param>
        public Cat(string Nickname, string Breed)
        {
            this.Nickname = Nickname;
            this.breed = Breed;
        }

        private string breed;

        /// <summary>
        /// Gets or sets the nickname of the cat.
        /// </summary>
        public string Nickname { get; set; }

        /// <summary>
        /// Gets the breed of the cat.
        /// </summary>
        public string Breed 
        { 
            get 
            { 
                return "Breed: " + this.breed; 
            } 
        }

        /// <summary>
        /// Makes the cat play.
        /// </summary>
        public void ToPlay() 
        { 
            Console.WriteLine($"{this.Nickname} plays..."); 
        }

        /// <summary>
        /// Makes the cat sleep.
        /// </summary>
        public void ToSleep() 
        { 
            Console.WriteLine($"{this.Nickname} is sleeping..."); 
        }

        /// <summary>
        /// Makes the cat eat.
        /// </summary>
        public void ToEat() 
        { 
            Console.WriteLine($"{this.Nickname} is eating..."); 
        }

        /// <summary>
        /// Makes the cat mew.
        /// </summary>
        public void ToMew() 
        { 
            Console.WriteLine($"Mew!"); 
        }
    }
}
