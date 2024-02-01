using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less06HeroDruidHunterWarrior
{
    /// <summary>
    /// Represents a Warrior character, inheriting from the internal Hero base class.
    /// </summary>
    internal class Warrior : Hero
    {
        /// <summary>
        /// Overrides the Motto method in the base class to provide a specialized battlecry for Warriors.
        /// </summary>
        public new void Motto()
        {
            Console.WriteLine($"{this.Name}: My hammer is ready!");
        }

        /// <summary>
        /// Instance variable for the Warrior's block damage.
        /// </summary>
        private uint blockDamage;

        /// <summary>
        /// Initializes a new instance of the Warrior class with the specified parameters.
        /// </summary>
        /// <param name="Name">The name of the Warrior.</param>
        /// <param name="Level">The level of the Warrior.</param>
        /// <param name="HitPoint">The initial hit points of the Warrior.</param>
        public Warrior(string Name, byte Level, uint HitPoint)
            : base(Name, Level, HitPoint)
        {
            // Set the Warrior's block damage to 2.
            this.blockDamage = 2;
        }

        /// <summary>
        /// Initializes a new instance of the Warrior class with default values.
        /// </summary>
        public Warrior() : this("", 1, 0)
        {
        }

        /// <summary>
        /// Overrides the Attacked method in the base class to factor in block damage for Warriors.
        /// </summary>
        /// <param name="Damage">The damage received from the attacker.</param>
        public new void Attacked(uint Damage)
        {
            base.Attacked(Damage / blockDamage);
        }
    }

}
