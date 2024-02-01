using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Less02HeroesGame
{
    internal class Hero
    {
        /// <summary>
        /// Gets or sets the name of the hero.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the level of the hero.
        /// </summary>
        public byte Level { get; set; }

        /// <summary>
        /// Gets or sets the hit points of the hero.
        /// </summary>
        public uint HitPoint { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="Hero"/> class.
        /// </summary>
        /// <param name="name">The name of the hero.</param>
        /// <param name="level">The level of the hero.</param>
        /// <param name="hitPoint">The hit points of the hero.</param>
        public Hero(string name, byte level, uint hitPoint)
        {
            Name = name;
            Level = level;
            HitPoint = hitPoint;
        }

        /// <summary>
        /// Increases the hit points of the hero by 10.
        /// </summary>
        public void Treatment()
        {
            this.HitPoint += 10;
        }

        /// <summary>
        /// Performs an attack and returns the attack points.
        /// </summary>
        /// <returns>The attack points.</returns>
        public uint Attack()
        {
            return 10;
        }

        /// <summary>
        /// Decreases the hit points of the hero by the specified amount.
        /// </summary>
        /// <param name="damage">The amount of damage received.</param>
        public void Attacked(uint damage)
        {
            this.HitPoint -= damage;
        }

        /// <summary>
        /// Retrieves information about the hero.
        /// </summary>
        /// <returns>A formatted string containing the hero's information.</returns>
        public string HeroInformation()
        {
            return String.Format("Name:{0,10} |  Level:{1,4} |  HitPoint:{2,6} |  Type:{3,12}",
                this.Name,
                this.Level,
                this.HitPoint,
                this.GetType().Name
                );
        }
    }
}
