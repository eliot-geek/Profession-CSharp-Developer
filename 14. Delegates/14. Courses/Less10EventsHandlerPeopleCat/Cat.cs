using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less10EventsHandlerPeopleCat
{
    /// <summary>
    /// Represents a Cat class.
    /// </summary>
    //class Cat : IComparable
    internal class Cat : IComparable<Cat>
    {
        /// <summary>
        /// Event triggered when the cat meows.
        /// </summary>
        public event Action<string> MewEvent;

        /// <summary>
        /// Represents the owner of the cat.
        /// </summary>
        private People ownew;

        /// <summary>
        /// Gets or sets the owner of the cat.
        /// </summary>
        public People Ownew
        {
            set
            {
                this.ownew = value;
                this.ownew.CatFood += s => this.ToEat();
            }
        }

        /// <summary>
        /// Represents the breed of the cat.
        /// </summary>
        private string breed;

        /// <summary>
        /// Represents the weight of the cat.
        /// </summary>
        private int weight;

        /// <summary>
        /// Constructs a new instance of the Cat class.
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
        /// Gets or sets the Weight of the cat.
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
        /// Plays with the cat.
        /// </summary>
        public void ToPlay() { Console.WriteLine($"{this.Nickname} is playing..."); }

        /// <summary>
        /// Makes the cat sleep.
        /// </summary>
        public void ToSleep() { Console.WriteLine($"{this.Nickname} is sleeping..."); }

        /// <summary>
        /// Feeds the cat.
        /// </summary>
        public void ToEat() { Console.WriteLine($"{this.Nickname} is eating..."); }

        /// <summary>
        /// Makes the cat meow and triggers the MewEvent.
        /// </summary>
        public void ToMew()
        {
            Console.WriteLine($"Mew!");
            MewEvent?.Invoke($"Cat {this.Nickname} published \"Mew\"");
        }

        /// <summary>
        /// Overrides the ToString method to return a string representation of the cat.
        /// </summary>
        /// <returns>A string representation of the cat.</returns>
        public override string ToString()
        {
            return $"{Nickname,10} {breed,10} {Weight,3}";
        }

        //public int CompareTo(object obj)
        //{
        //    var other = (Cat)obj;
        //    if (this.weight > other.weight) return 1;
        //    else if (this.weight < other.weight) return -1;
        //    else return 0;
        //}

        /// <summary>
        /// Compares the cat's weight with another cat's weight.
        /// </summary>
        /// <param name="other">The cat to compare with.</param>
        /// <returns>An integer indicating the relative order of the objects being compared.</returns>
        public int CompareTo(Cat other)
        {
            if (this.weight > other.weight) return 1;
            else if (this.weight < other.weight) return -1;
            else return 0;
        }
    }
}
