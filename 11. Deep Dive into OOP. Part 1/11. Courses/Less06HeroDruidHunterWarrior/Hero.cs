using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less06HeroDruidHunterWarrior
{
    /// <summary>
    /// Represents a base class for different hero characters in the game.
    /// </summary>
    internal class Hero
    {
        /// <summary>
        /// Defines a method to display the motto of the hero, emphasizing the fight for victory.
        /// </summary>
        public void Motto()
        {
            Console.WriteLine("We fight for the sake of victory!");
        }

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
        /// Simulates a normal attack and returns the damage dealt.
        /// </summary>
        /// <returns>The damage dealt by the hero.</returns>
        public uint Attack()
        {
            return 10;
        }

        /// <summary>
        /// Handles an incoming attack and updates the hero's hit points.
        /// </summary>
        /// <param name="Damage">The damage received from the attacker.</param>
        public void Attacked(uint Damage)
        {
            // Check if the hero is already defeated.
            if (this.hitPoint == 0)
            {
                this.Tavern();
            }
            else
            {
                // Check if the hero will survive the attack.
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
    }
}
