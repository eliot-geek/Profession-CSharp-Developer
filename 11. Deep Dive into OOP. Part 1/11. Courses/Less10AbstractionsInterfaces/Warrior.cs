using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less10AbstractionsInterfaces
{
    internal class Warrior : Hero
    {
        // The use of the 'new' keyword signifies deliberate method hiding, indicating that this is intentional and not an error.
        //public new void Motto()

        /// <summary>
        /// Overrides the Motto method in the base class to provide a unique motto for Warriors.
        /// </summary>
        /// <remarks>
        /// The use of the 'new' keyword signifies deliberate method hiding, indicating that this is intentional and not an error.
        /// </remarks>
        public override void Motto()
        {
            Console.WriteLine($"{this.Name}: My hammer is ready!");
        }

        /// <summary>
        /// Variable to store the block damage factor for Warriors.
        /// </summary>
        uint blockDamage;


        /// <summary>
        /// Initializes a new instance of the Warrior class with the specified parameters.
        /// </summary>
        /// <param name="Name">The name of the Warrior.</param>
        /// <param name="Level">The level of the Warrior.</param>
        /// <param name="HitPoint">The initial hit points of the Warrior.</param>
        public Warrior(string Name, byte Level, uint HitPoint)
            : base(Name, Level, HitPoint)
        {
            // Sets the default block damage factor for Warriors.
            this.blockDamage = 2;
        }

        /// <summary>
        /// Initializes a new instance of the Warrior class with default values.
        /// </summary>
        public Warrior() : this("", 1, 0)
        {
        }

        //Overrides the Attacked method in the base class, using the 'new' keyword to indicate intentional method hiding.
        //The incoming damage to be processed in the overridden method.
        //public new void Attacked(uint Damage)


        /// <summary>
        /// Overrides the Attacked method in the base class to apply the block damage factor for Warriors.
        /// </summary>
        /// <param name="Damage">The incoming damage to be reduced by the block damage factor.</param>
        public override void Attacked(uint Damage)
        {
            // Calls the base class's Attacked method with the adjusted damage based on the block damage factor.
            base.Attacked(Damage / blockDamage);
        }
    }
}
