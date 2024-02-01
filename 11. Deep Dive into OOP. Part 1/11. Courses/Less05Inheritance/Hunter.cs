using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less05Inheritance
{
    /// <summary>
    /// Represents a Hunter character in the game with specific attributes and actions.
    /// </summary>
    internal class Hunter
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
        /// Static list to store existing Hunter names for uniqueness.
        /// </summary>
        static List<string> dbNames;

        /// <summary>
        /// Static constructor to initialize static members.
        /// </summary>
        static Hunter()
        {
            randomize = new Random();
            defIndexName = 1;
            dbNames = new List<string>();
        }

        /// <summary>
        /// Instance variable for the Hunter's level.
        /// </summary>
        byte level;

        /// <summary>
        /// Instance variable for the Hunter's current hit points.
        /// </summary>
        uint hitPoint;

        /// <summary>
        /// Instance variable for the Hunter's maximum hit points.
        /// </summary>
        uint maxHitPoint;

        /// <summary>
        /// Gets or sets the name of the Hunter.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets the level of the Hunter.
        /// </summary>
        public byte Level { get { return this.level; } }

        /// <summary>
        /// Gets the current hit points of the Hunter.
        /// </summary>
        public uint HitPoint { get { return this.hitPoint; } }

        /// <summary>
        /// Initializes a new instance of the Hunter class with the specified parameters.
        /// </summary>
        /// <param name="Name">The name of the Hunter.</param>
        /// <param name="Level">The level of the Hunter.</param>
        /// <param name="HitPoint">The initial hit points of the Hunter.</param>
        public Hunter(string Name, byte Level, uint HitPoint)
        {
            // Check for empty name or name duplication, generate a unique name if necessary.
            if (Name == String.Empty || Hunter.dbNames.Contains(Name))
            {
                Name = $"{Guid.NewGuid().ToString().Substring(0, 5)} #{Hunter.defIndexName++}";
            }

            this.Name = Name;
            Hunter.dbNames.Add(Name);
            this.level = Level;

            // Set hit points based on the provided value or a random value.
            HitPoint = HitPoint != 0 ? HitPoint : (uint)Hunter.randomize.Next(100, 400);
            this.hitPoint = HitPoint;
            this.maxHitPoint = HitPoint;
        }

        /// <summary>
        /// Initializes a new instance of the Hunter class with default values.
        /// </summary>
        public Hunter() : this("", 1, 0)
        {
        }

        /// <summary>
        /// Heals the Hunter by the specified amount.
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
        /// <returns>The damage dealt by the Hunter.</returns>
        public uint Attack() { return 10; }

        /// <summary>
        /// Simulates a headshot attack with a chance to deal extra damage.
        /// </summary>
        /// <returns>The total damage dealt by the Hunter.</returns>
        public uint HeadShot()
        {
            return (Hunter.randomize.Next(4) != 0) ?
                        this.Attack() :
                        this.Attack() + (uint)Hunter.randomize.Next(10, 20);
        }

        /// <summary>
        /// Handles an incoming attack and updates the Hunter's hit points.
        /// </summary>
        /// <param name="Damage">The damage received from the attacker.</param>
        public void Attacked(uint Damage)
        {
            // Check if the Hunter is already defeated.
            if (this.hitPoint == 0)
            {
                this.Tavern();
            }
            else
            {
                // Check if the Hunter will survive the attack.
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
        /// Private method to handle the Hunter's death.
        /// </summary>
        private void Die()
        {
            Console.WriteLine($"{this.Name} has a critical Life Reserve level");
            this.Tavern();
        }

        /// <summary>
        /// Private method to indicate the Hunter is in the tavern.
        /// </summary>
        private void Tavern()
        {
            Console.WriteLine($"The hero {this.Name} is in the tavern");
        }

        /// <summary>
        /// Returns a formatted string containing information about the Hunter.
        /// </summary>
        /// <returns>Formatted string with Hunter information.</returns>
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
