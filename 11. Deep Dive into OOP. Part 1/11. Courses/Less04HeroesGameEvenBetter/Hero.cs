using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less04HeroesGameEvenBetter
{
    /// <summary>
    /// Class Hero
    /// </summary>
    internal class Hero
    {
        static uint defIndexName;
        static Random randomize = new Random();
        static List<string> dbNames;

        /// <summary>
        /// Initializes static members of the Hero class.
        /// </summary>
        static Hero()
        {
            defIndexName = 1;
            randomize = new Random();
            dbNames = new List<string>();
        }

        byte level;
        uint hitPoint;
        uint maxHitPoint;

        /// <summary>
        /// Gets or sets the hero's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets the hero's level.
        /// </summary>
        public byte Level { get { return this.level; } }

        /// <summary>
        /// Gets the hero's current hit points.
        /// </summary>
        public uint HitPoint { get { return this.hitPoint; } }

        /// <summary>
        /// Initializes a new instance of the Hero class.
        /// </summary>
        /// <param name="Name">The name of the hero.</param>
        /// <param name="Level">The level of the hero.</param>
        /// <param name="HitPoint">The initial hit points of the hero.</param>
        public Hero(string Name, byte Level, uint HitPoint)
        {
            if (Name == String.Empty || Hero.dbNames.Contains(Name))
            {
                Name = $"{Guid.NewGuid().ToString().Substring(0, 5)} #{Hero.defIndexName++}";
            }

            this.Name = Name;
            Hero.dbNames.Add(Name);
            this.level = Level;

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
        /// Heals the hero by a specified amount.
        /// </summary>
        /// <param name="Hp">The amount of hit points to heal.</param>
        public void Treatment(uint Hp = 10)
        {
            if (this.hitPoint == 0)
            {
                Console.WriteLine($"\nTreatment is not possible, {this.Name} is in the tavern");
            }
            else
            {
                this.hitPoint = this.hitPoint + Hp <= this.maxHitPoint ? this.hitPoint + Hp : this.maxHitPoint;
            }
        }

        /// <summary>
        /// Performs an attack, returning the damage dealt.
        /// </summary>
        /// <returns>The damage dealt.</returns>
        public uint Attack()
        {
            return 10;
        }

        /// <summary>
        /// Inflicts damage on the hero.
        /// </summary>
        /// <param name="Damage">The amount of damage to inflict.</param>
        public void Attacked(uint Damage)
        {
            if (this.hitPoint == 0)
            {
                this.Tavern();
            }
            else
            {
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
        /// Handles the hero's death.
        /// </summary>
        private void Die()
        {
            Console.WriteLine($"\n{this.Name} has reached a critical life reserve level");
            this.Tavern();
        }

        /// <summary>
        /// Handles the hero's presence in the tavern.
        /// </summary>
        private void Tavern()
        {
            Console.WriteLine($"\nThe hero {this.Name} is in the tavern");
        }

        /// <summary>
        /// Gets a string representation of the hero's information.
        /// </summary>
        /// <returns>The hero's information.</returns>
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
