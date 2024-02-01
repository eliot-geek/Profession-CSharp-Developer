using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less05Inheritance
{
    /// <summary>
    /// Represents a warrior in a game with basic attributes and actions.
    /// </summary>
    class Warrior
    {
        /// <summary>
        /// Static variable to track the default index for generating names.
        /// </summary>
        static uint defIndexName;

        /// <summary>
        /// Static variable for generating random values.
        /// </summary>
        static Random randomize;

        /// <summary>
        /// Static list to store existing warrior names for uniqueness.
        /// </summary>
        static List<string> dbNames;

        /// <summary>
        /// Static constructor to initialize static members.
        /// </summary>
        static Warrior()
        {
            defIndexName = 1;
            randomize = new Random();
            dbNames = new List<string>();
        }

        /// <summary>
        /// Instance variable for the warrior's level.
        /// </summary>
        byte level;

        /// <summary>
        /// Instance variable for the warrior's current hit points.
        /// </summary>
        uint hitPoint;

        /// <summary>
        /// Instance variable for the warrior's maximum hit points.
        /// </summary>
        uint maxHitPoint;

        /// <summary>
        /// Instance variable for the warrior's block damage factor.
        /// </summary>
        uint blockDamage;

        /// <summary>
        /// Gets or sets the name of the warrior.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets the level of the warrior.
        /// </summary>
        public byte Level { get { return this.level; } }

        /// <summary>
        /// Gets the current hit points of the warrior.
        /// </summary>
        public uint HitPoint { get { return this.hitPoint; } }

        /// <summary>
        /// Initializes a new instance of the Warrior class with the specified parameters.
        /// </summary>
        /// <param name="Name">The name of the warrior.</param>
        /// <param name="Level">The level of the warrior.</param>
        /// <param name="HitPoint">The initial hit points of the warrior.</param>
        public Warrior(string Name, byte Level, uint HitPoint)
        {
            // Check for empty name or name duplication, generate a unique name if necessary.
            if (Name == String.Empty || Warrior.dbNames.Contains(Name))
            {
                Name = $"{Guid.NewGuid().ToString().Substring(0, 5)} #{Warrior.defIndexName++}";
            }

            this.Name = Name;
            Warrior.dbNames.Add(Name);
            this.level = Level;

            // Set hit points based on the provided value or a random value.
            HitPoint = HitPoint != 0 ? HitPoint : (uint)Warrior.randomize.Next(100, 400);
            this.hitPoint = HitPoint;
            this.maxHitPoint = HitPoint;
            blockDamage = 2;
        }

        /// <summary>
        /// Initializes a new instance of the Warrior class with default values.
        /// </summary>
        public Warrior() : this("", 1, 0)
        {
        }

        /// <summary>
        /// Heals the warrior by the specified amount.
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

        public uint Attack()
        {
            return 10;
        }

        /// <summary>
        /// Handles an incoming attack and updates the warrior's hit points.
        /// </summary>
        /// <param name="Damage">The damage received from the attacker.</param>
        public void Attacked(uint Damage)
        {
            // Adjust damage based on block damage factor.
            Damage /= this.blockDamage;

            // Check if the warrior is already defeated.
            if (this.hitPoint == 0)
            {
                this.Tavern();
            }
            else
            {
                // Check if the warrior will survive the attack.
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
        /// Private method to handle the warrior's death.
        /// </summary>
        private void Die()
        {
            Console.WriteLine($"{this.Name} has a critical Life Reserve level");
            this.Tavern();
        }

        /// <summary>
        /// Private method to indicate the warrior is in the tavern.
        /// </summary>
        private void Tavern()
        {
            Console.WriteLine($"The hero {this.Name} is in the tavern");
        }

        /// <summary>
        /// Returns a formatted string containing information about the warrior.
        /// </summary>
        /// <returns>Formatted string with warrior information.</returns>
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
