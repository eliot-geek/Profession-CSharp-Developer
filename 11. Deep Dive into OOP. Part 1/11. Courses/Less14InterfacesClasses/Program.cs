namespace Less14InterfacesClasses
{
    /// <summary>
    /// Definition of the first interface I1.
    /// </summary>
    interface I1
    {
        /// <summary>
        /// Method M declaration.
        /// </summary>
        void M();
    }

    /// <summary>
    /// Definition of the second interface I2.
    /// </summary>
    interface I2
    {
        /// <summary>
        /// Method M declaration.
        /// </summary>
        void M();
    }

    /// <summary>
    /// Class A implements both I1 and I2 interfaces.
    /// </summary>
    class A : I1, I2
    {
        /// <summary>
        /// Implementation of the M method from interface I1 and I2.
        /// </summary>
        public void M()
        {
            Console.WriteLine("A.M()");
        }
    }


    /// <summary>
    /// Class B implements both I1 and I2 interfaces.
    /// </summary>
    class B : I1, I2
    {
        /// <summary>
        /// Implementation of the M method from interface I1 and I2.
        /// </summary>
        public void M() 
        { 
            Console.WriteLine("B.M()"); 
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();      // Creating an instance of class A
            
            ((I1)a).M();        // Calling the M method from interface I1 through the instance of class A

            ((I2)a).M();        // Calling the M method from interface I2 through the instance of class A

            B b = new B();      // Creating an instance of class B

            ((I1)b).M();        // Calling the M method from interface I1 through the instance of class B

            ((I2)b).M();        // Calling the M method from interface I2 through the instance of class B

        }
    }
}
