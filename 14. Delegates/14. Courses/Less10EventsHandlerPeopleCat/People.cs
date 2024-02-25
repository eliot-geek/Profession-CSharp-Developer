using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less10EventsHandlerPeopleCat
{
    /// <summary>
    /// Represents a person who can feed a cat.
    /// </summary>
    internal class People
    {
        /// <summary>
        /// Gets or sets the name of the person.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Event triggered when the person feeds the cat.
        /// </summary>
        public event Action<string> CatFood;

        /// <summary>
        /// Represents the cat associated with the person.
        /// </summary>
        private Cat cat;

        /// <summary>
        /// Constructs a new instance of the People class.
        /// </summary>
        /// <param name="Name">The name of the person.</param>
        /// <param name="ConcreteCat">The concrete cat associated with the person.</param>
        public People(string Name, Cat ConcreteCat)
        {
            this.Name = Name;
            this.cat = ConcreteCat;
            
            // Subscribe to the MewEvent of the concrete cat to be notified when the cat meows.
            ConcreteCat.MewEvent += a => Console.WriteLine($"{this.Name} went to feed the cat : {ConcreteCat.Nickname}");
        }

        /// <summary>
        /// Feeds the associated cat.
        /// </summary>
        public void FeedTheCat()
        {
            Console.WriteLine($"{cat.Nickname}, eat, eat, eat food is served! ");

            // Invoke the CatFood event to indicate that the cat is being fed.
            CatFood?.Invoke("Delicious");
        }
    }
}
