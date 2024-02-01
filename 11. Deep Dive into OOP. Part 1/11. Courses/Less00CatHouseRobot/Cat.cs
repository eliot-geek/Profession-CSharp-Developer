using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less00CatHouseRobot
{
    /// <summary>
    /// Represents a Cat class.
    /// </summary>
    internal class Cat
    {
        /// <summary>
        /// Private field to store the breed of the cat.
        /// </summary>
        private string breed;

        /// <summary>
        /// Initializes a new instance of the <see cref="Cat"/> class.
        /// </summary>
        /// <param name="Nickname">The nickname of the cat.</param>
        /// <param name="breed">The breed of the cat.</param>
        public Cat(string Nickname, string breed)
        {
            this.Nickname = Nickname;
            this.breed = breed;
        }

        // We can transform it into a field without using get and set, but it's not a recommended practice
        /// <summary>
        /// Gets or sets the nickname of the cat.
        /// </summary>
        public string Nickname { get; set; }

        // This version simply returns the data.
        //public string Breed { get { return this.breed; } }               


        // This version adds behavior to the property.
        /// <summary>
        /// Gets the breed of the cat with additional information.
        /// </summary>
        public string Breed { get { return "Breed: " + this.breed; } }


        /// <summary>
        /// Method that defines the logic of the cat's play.
        /// </summary>
        public void ToPlay()
        {
            Console.WriteLine($"{this.Nickname} is playing....");
        }

        /// <summary>
        /// Method that defines the logic of the cat's sleep.
        /// </summary>
        public void ToSleep()
        {
            Console.WriteLine($"{this.Nickname} is sleeping....");
        }

        /// <summary>
        /// Method that defines the logic of the cat's nutrition.
        /// </summary>
        public void ToEat()
        {
            Console.WriteLine($"{this.Nickname} is eating....");
        }

        /// <summary>
        /// Method that defines the cat's meow sound.
        /// </summary>
        public void ToMew()
        {
            Console.WriteLine($"{this.Nickname} is making the sound \"Meow!!\"");
        }
    }

}
