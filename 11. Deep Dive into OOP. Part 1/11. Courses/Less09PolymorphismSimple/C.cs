using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less09PolymorphismSimple
{
    // C# types all from Object in this case F12 on Object


    /// <summary>
    /// Class C with a virtual method M.
    /// </summary>
    internal class C
    {
        /// <summary>
        /// A virtual method M in class C.
        /// </summary>
        public virtual void M()
        {
            Console.WriteLine("C.M()");
        }
    }

    /// <summary>
    /// Class D inheriting from class C with an overridden method M.
    /// </summary>
    internal class D : C
    {
        /// <summary>
        /// An overridden method M in class D.
        /// </summary>
        public override void M()
        {
            Console.WriteLine("D.M()");
        }
    }
}
