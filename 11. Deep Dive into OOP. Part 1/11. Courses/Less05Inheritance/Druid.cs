using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less05Inheritance
{
    /// <summary>
    /// Represents a Druid character in the game with specific attributes and actions.
    /// </summary>
    internal class Druid
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
        /// Static list to store existing Druid names for uniqueness.
        /// </summary>
        static List<string> dbNames;

        /// <summary>
        /// Static constructor to initialize static members.
        /// </summary>
        static Druid()
        {
            defIndexName = 1;
            randomize = new Random();
            dbNames = new List<string>();
        }

        /// <summary>
        /// Instance variable for the Druid's level.
        /// </summary>
        byte level;

        /// <summary>
        /// Instance variable for the Druid's current hit points.
        /// </summary>
        uint hitPoint;

        /// <summary>
        /// Instance variable for the Druid's maximum hit points.
        /// </summary>
        uint maxHitPoint;

        /// <summary>
        /// Gets or sets the name of the Druid.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets the level of the Druid.
        /// </summary>
        public byte Level { get { return this.level; } }

        /// <summary>
        /// Gets the current hit points of the Druid.
        /// </summary>
        public uint HitPoint { get { return this.hitPoint; } }

        /// <summary>
        /// Initializes a new instance of the Druid class with the specified parameters.
        /// </summary>
        /// <param name="Name">The name of the Druid.</param>
        /// <param name="Level">The level of the Druid.</param>
        /// <param name="HitPoint">The initial hit points of the Druid.</param>
        public Druid(string Name, byte Level, uint HitPoint)
        {
            // Check for empty name or name duplication, generate a unique name if necessary.
            if (Name == String.Empty || Druid.dbNames.Contains(Name))
            {
                Name = $"{Guid.NewGuid().ToString().Substring(0, 5)} #{Druid.defIndexName++}";
            }

            this.Name = Name;
            Druid.dbNames.Add(Name);
            this.level = Level;

            // Set hit points based on the provided value or a random value.
            HitPoint = HitPoint != 0 ? HitPoint : (uint)Druid.randomize.Next(100, 400);
            this.hitPoint = HitPoint;
            this.maxHitPoint = HitPoint;
        }

        /// <summary>
        /// Initializes a new instance of the Druid class with default values.
        /// </summary>
        public Druid() : this("", 1, 0)
        {
        }

        /// <summary>
        /// Heals the Druid by the specified amount.
        /// </summary>
        /// <param name="Hp">The amount of hit points to heal. Default is 10.</param>
        public void Treatment(uint Hp = 10)
        {
            // Increase the healing amount by 50% for the Druid.
            Hp = (uint)(Hp * 1.5);

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
        /// Performs a healing action, returning the amount healed by the Druid.
        /// </summary>
        /// <returns>The amount healed by the Druid.</returns>
        public uint Heal()
        {
            return (uint)Druid.randomize.Next(5, 10);
        }

        /// <summary>
        /// Simulates a normal attack and returns the damage dealt.
        /// </summary>
        /// <returns>The damage dealt by the Druid.</returns>
        public uint Attack()
        {
            return 10;
        }

        /// <summary>
        /// Handles an incoming attack and updates the Druid's hit points.
        /// </summary>
        /// <param name="Damage">The damage received from the attacker.</param>
        public void Attacked(uint Damage)
        {
            // Check if the Druid is already defeated.
            if (this.hitPoint == 0)
            {
                this.Tavern();
            }
            else
            {
                // Check if the Druid will survive the attack.
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
        /// Private method to handle the Druid's death.
        /// </summary>
        private void Die()
        {
            Console.WriteLine($"{this.Name} has a critical Life Reserve level");
            this.Tavern();
        }

        /// <summary>
        /// Private method to indicate the Druid is in the tavern.
        /// </summary>
        private void Tavern()
        {
            Console.WriteLine($"The hero {this.Name} is in the tavern");
        }

        /// <summary>
        /// Returns a formatted string containing information about the Druid.
        /// </summary>
        /// <returns>Formatted string with Druid information.</returns>
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
