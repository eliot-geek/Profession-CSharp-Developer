using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less09PolymorphismSimple
{
    internal class A
    {
        //public void M()


        /// <summary>
        /// A base method M. (Add virtual)
        /// </summary>
        public virtual void M()
        {
            Console.WriteLine("A.M()");
        }
    }

    internal class B : A
    {
        //public new void M()


        /// <summary>
        /// An overridden method M in class B. (Change new by override)
        /// </summary>
        public override void M()
        {
            Console.WriteLine("B.M()");
        }
    }
}
