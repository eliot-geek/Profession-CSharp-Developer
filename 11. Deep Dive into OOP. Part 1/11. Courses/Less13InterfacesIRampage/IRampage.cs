using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less13InterfacesIRampage
{
    /// <summary>
    /// The IRampage interface defines methods and properties related to a hero's rampage abilities.
    /// </summary>
    internal interface IRampage
    {
        /// <summary>
        /// Gets or sets the current charge level for the hero's special abilities.
        /// </summary>
        int Charge { get; set; }

        /// <summary>
        /// Resets the charge level for the hero's special abilities to the maximum value.
        /// </summary>
        void Recharge();

        /// <summary>
        /// Performs a powerful special attack on the specified target, consuming the hero's charge.
        /// </summary>
        /// <param name="Target">The target of the ultra attack.</param>
        void UltraAttack(Hero Target);
    }
}
