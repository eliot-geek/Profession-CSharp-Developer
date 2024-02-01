using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less06HeroDruidHunterWarrior
{
    /// <summary>
    /// Represents a Hunter character, inheriting from the Hero base class.
    /// </summary>
    internal class Hunter : Hero
    {
        /// <summary>
        /// Overrides the Motto method in the base class to provide a specialized message for Hunters.
        /// </summary>
        public new void Motto()
        {
            Console.WriteLine($"{this.Name} : The hunt has begun!");
        }

        /// <summary>
        /// Initializes a new instance of the Hunter class with the specified parameters.
        /// </summary>
        /// <param name="Name">The name of the Hunter.</param>
        /// <param name="Level">The level of the Hunter.</param>
        /// <param name="HitPoint">The initial hit points of the Hunter.</param>
        public Hunter(string Name, byte Level, uint HitPoint)
            : base(Name, Level, HitPoint)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Hunter class with default values.
        /// </summary>
        public Hunter() : this("", 1, 0)
        {
        }

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
    }
}
