using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less07InheritanceSimple
{
    /// <summary>
    /// Represents a base class A with a public method M().
    /// </summary>
    internal class A
    {
        // We can't access with the modifier private
        //private void M()
        //protected void M()


        /// <summary>
        /// Public method M() that prints a message to the console.
        /// </summary>
        public void M()
        {
            Console.WriteLine("A.M()");
        }
    }

    //class B : A
    //{
    //    // can't call with access protected
    //}


    /// <summary>
    /// Represents a derived class B inheriting from class A with a new implementation of method M().
    /// </summary>
    internal class B : A
    {
        //public void MyM()
        //{
        //    base.M();
        //}


        /// <summary>
        /// New implementation of method M() specific to class B.
        /// keyword new is for the computer to understand that it isn't an error, so you did it intentionnally
        /// </summary>
        public new void M() 
        {
            Console.WriteLine("B.M()");
        }
    }
}
