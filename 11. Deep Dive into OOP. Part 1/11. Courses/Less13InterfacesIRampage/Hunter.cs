using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less13InterfacesIRampage
{
    /// <summary>
    /// The Hunter class represents a type of hero specialized in hunting and ranged attacks.
    /// </summary>
    internal class Hunter : Hero, IRampage
    {
        /// <summary>
        /// Initializes a new instance of the Hunter class with specified attributes.
        /// </summary>
        /// <param name="Name">The name of the Hunter.</param>
        /// <param name="Level">The level of the Hunter.</param>
        /// <param name="HitPoint">The initial hit points of the Hunter.</param>
        public Hunter(string Name, byte Level, uint HitPoint)
            : base(Name, Level, HitPoint)
        {
            this.Charge = 3;
        }

        /// <summary>
        /// Initializes a new instance of the Hunter class with default attributes.
        /// </summary>
        public Hunter() : this("", 1, 0)
        {
        }

        /// <summary>
        /// Overrides the Motto method to display the Hunter's specific motto.
        /// </summary>
        public override void Motto()
        {
            Console.WriteLine($"{this.Name}: The hunt has begun!");
        }

        /// <summary>
        /// Performs a headshot attack on the specified target, potentially dealing extra damage.
        /// </summary>
        /// <param name="Target">The target of the headshot attack.</param>
        public void HeadShot(Hero Target)
        {
            Target.Attacked(10);
            if (Hunter.randomize.Next(4) != 0)
            {
                Target.Attacked((uint)Hunter.randomize.Next(10, 20));
            }
        }

        /// <summary>
        /// Gets or sets the current charge level for the Hunter's special abilities.
        /// </summary>
        public int Charge { get; set; }

        /// <summary>
        /// Resets the charge level for the Hunter's special abilities to the maximum value.
        /// </summary>
        public void Recharge()
        {
            this.Charge = 3;
        }

        /// <summary>
        /// Performs a powerful ranged attack on the specified target, consuming the Hunter's charge.
        /// </summary>
        /// <param name="Target">The target of the ultra attack.</param>
        public void UltraAttack(Hero Target)
        {
            for (int i = 0; i < this.Charge; i++)
            {
                Target.Attacked(10);
            }
            this.Charge = 0;
        }
    }

}
