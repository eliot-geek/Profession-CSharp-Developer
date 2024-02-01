using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less13InterfacesIRampage
{
    internal class Warrior : Hero, IRampage
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
        /// Initializes a new instance of the Warrior class with the specified name, level, and hit points.
        /// </summary>
        /// <param name="Name">The name of the warrior.</param>
        /// <param name="Level">The level of the warrior.</param>
        /// <param name="HitPoint">The initial hit points of the warrior.</param>
        public Warrior(string Name, byte Level, uint HitPoint)
            : base(Name, Level, HitPoint)
        {
            // Set the block damage factor for the warrior.
            this.blockDamage = 2;

            // Set the initial charge for the warrior's special abilities.
            this.Charge = 5;
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

        /// <summary>
        /// Gets or sets the charge for the warrior's special abilities.
        /// </summary>
        public int Charge { get; set; }

        /// <summary>
        /// Recharges the warrior's special ability charge.
        /// </summary>
        public void Recharge()
        {
            this.Charge = 5;
        }

        /// <summary>
        /// Performs an ultra attack on the specified target using the warrior's special ability.
        /// </summary>
        /// <param name="Target">The target hero to be attacked.</param>
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
