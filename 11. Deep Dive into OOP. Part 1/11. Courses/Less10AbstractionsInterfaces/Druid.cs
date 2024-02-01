using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less10AbstractionsInterfaces
{
    /// <summary>
    /// Represents a Druid character, inheriting from the base class Hero.
    /// </summary>
    internal class Druid : Hero
    {
        //public new void Motto()

        /// <summary>
        /// Overrides the Motto method in the base class to provide a specialized blessing for Druids.
        /// </summary>
        public override void Motto()
        {
            Console.WriteLine($"{this.Name}: I bless everyone!");
        }

        /// <summary>
        /// Initializes a new instance of the Druid class with the specified parameters.
        /// </summary>
        /// <param name="Name">The name of the Druid.</param>
        /// <param name="Level">The level of the Druid.</param>
        /// <param name="HitPoint">The initial hit points of the Druid.</param>
        public Druid(string Name, byte Level, uint HitPoint)
            : base(Name, Level, HitPoint)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Druid class with default values.
        /// </summary>
        public Druid() : this("", 1, 0)
        {
        }

        /// <summary>
        /// Overrides the Treatment method in the base class to apply a healing bonus for Druids.
        /// </summary>
        /// <param name="Hp">The amount of hit points to heal. Default is 10.</param>
        public new void Treatment(uint Hp = 10)
        {
            // Apply a healing bonus for Druids.
            Hp = (uint)(Hp * 1.5);
            base.Treatment(Hp);
        }

        /// <summary>
        /// Simulates a healing ability unique to Druids, returning the amount healed.
        /// </summary>
        /// <returns>The amount of healing performed by the Druid.</returns>
        public uint Heal()
        {
            return (uint)Druid.randomize.Next(5, 10);
        }
    }
}
