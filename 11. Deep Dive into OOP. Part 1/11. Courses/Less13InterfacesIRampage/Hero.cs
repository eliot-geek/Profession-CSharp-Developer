using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less13InterfacesIRampage
{
    /// <summary>
    /// Represents a base class for various hero characters in a game, providing common functionality.
    /// </summary>
    internal abstract class Hero
    {
        //Method that prints a common motto for all hero types.
        //public void Motto() { Console.WriteLine("We fight for the sake of victory!"); }

        //Virtual method that prints a unique motto for each hero type.
        //public virtual void Motto() { Console.WriteLine("We fight for the sake of victory!");}

        /// <summary>
        /// An abstract method representing the motto of a hero.
        /// </summary>
        public abstract void Motto();

        /// <summary>
        /// Static variable to track the default index for generating names.
        /// </summary>
        protected static uint defIndexName;

        /// <summary>
        /// Static variable for generating random values.
        /// </summary>
        protected static Random randomize;

        /// <summary>
        /// Static list to store existing hero names for uniqueness.
        /// </summary>
        protected static List<string> dbNames;

        /// <summary>
        /// Static constructor to initialize static members.
        /// </summary>
        static Hero()
        {
            randomize = new Random();
            defIndexName = 1;
            dbNames = new List<string>();
        }

        /// <summary>
        /// Instance variable for the hero's level.
        /// </summary>
        protected byte level;

        /// <summary>
        /// Instance variable for the hero's current hit points.
        /// </summary>
        protected uint hitPoint;

        /// <summary>
        /// Instance variable for the hero's maximum hit points.
        /// </summary>
        protected uint maxHitPoint;

        /// <summary>
        /// Gets or sets the name of the hero.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets the level of the hero.
        /// </summary>
        public byte Level { get { return this.level; } }

        /// <summary>
        /// Gets the current hit points of the hero.
        /// </summary>
        public uint HitPoint { get { return this.hitPoint; } }

        /// <summary>
        /// Initializes a new instance of the Hero class with the specified parameters.
        /// </summary>
        /// <param name="Name">The name of the hero.</param>
        /// <param name="Level">The level of the hero.</param>
        /// <param name="HitPoint">The initial hit points of the hero.</param>
        public Hero(string Name, byte Level, uint HitPoint)
        {
            // Check for empty name or name duplication, generate a unique name if necessary.
            if (Name == String.Empty || Hero.dbNames.Contains(Name))
            {
                Name = $"{Guid.NewGuid().ToString().Substring(0, 5)} #{Hero.defIndexName++}";
            }

            this.Name = Name;
            Hero.dbNames.Add(Name);
            this.level = Level;

            // Set hit points based on the provided value or a random value.
            HitPoint = HitPoint != 0 ? HitPoint : (uint)Hero.randomize.Next(100, 400);
            this.hitPoint = HitPoint;
            this.maxHitPoint = HitPoint;
        }

        /// <summary>
        /// Initializes a new instance of the Hero class with default values.
        /// </summary>
        public Hero() : this("", 1, 0)
        {
        }

        /// <summary>
        /// Heals the hero by the specified amount.
        /// </summary>
        /// <param name="Hp">The amount of hit points to heal. Default is 10.</param>
        public void Treatment(uint Hp = 10)
        {
            // Check if healing is possible and adjust hit points accordingly.
            if (this.hitPoint == 0)
            {
                Console.WriteLine($"Treatment is not possible, {this.Name} in the tavern");
            }
            else
            {
                this.hitPoint = this.hitPoint + Hp <= this.maxHitPoint ? this.hitPoint + Hp : this.maxHitPoint;
            }
        }

        /// <summary>
        /// Performs a regular attack, dealing a default amount of damage.
        /// </summary>
        /// <returns>The damage dealt in the regular attack.</returns>
        public uint Attack()
        {
            return 10;
        }

        /// <summary>
        /// Performs an attack on the specified target hero, dealing a default amount of damage.
        /// </summary>
        /// <param name="Target">The target hero to be attacked.</param>
        public void Attack(Hero Target)
        {
            if (Target != this) Target.Attacked(10);
        }


        //public void Attacked(uint Damage)


        /// <summary>
        /// Handles an incoming attack and updates the hero's hit points.
        /// </summary>
        /// <param name="Damage">The damage received from the attacker.</param>
        public virtual void Attacked(uint Damage)
        {
            // Check if the hero is already defeated
            if (this.hitPoint == 0)
            {
                this.Tavern();
            }
            else
            {
                // Check if the hero will survive the attack
                if (this.hitPoint - Damage <= 0)
                {
                    this.hitPoint = 0;
                    this.Die();
                }
                else
                {
                    this.hitPoint -= Damage;
                }
            }
        }

        /// <summary>
        /// Private method to handle the hero's death.
        /// </summary>
        private void Die()
        {
            Console.WriteLine($"{this.Name} has a critical Life Reserve level");
            this.Tavern();
        }

        /// <summary>
        /// Private method to indicate the hero is in the tavern.
        /// </summary>
        private void Tavern()
        {
            Console.WriteLine($"The hero {this.Name} is in the tavern");
        }

        /// <summary>
        /// Returns a formatted string containing information about the hero.
        /// </summary>
        /// <returns>Formatted string with hero information.</returns>
        public string HeroInformation()
        {
            return String.Format("Name:{0,10} |  Level:{1,4} |  HitPoint:{2,6} |  Type:{3,10}",
                this.Name,
                this.Level,
                this.HitPoint,
                this.GetType().Name
                );
        }

        /// <summary>
        /// Overrides the default ToString method to provide a custom string representation of the hero.
        /// Redirect or modify the sprint
        /// </summary>
        /// <returns>Formatted string with hero information.</returns>
        public override string ToString()
        {
            return String.Format("Name:{0,10} |  Level:{1,4} |  HitPoint:{2,6} |  Type:{3,10}",
                this.Name,
                this.Level,
                this.HitPoint,
                this.GetType().Name
                );
        }
    }
}
