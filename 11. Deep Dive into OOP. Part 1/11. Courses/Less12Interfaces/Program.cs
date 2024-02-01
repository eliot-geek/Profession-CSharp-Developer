namespace Less12Interfaces
{
    /// <summary>
    /// Class A with a method M.
    /// </summary>
    class A
    {
        /// <summary>
        /// Method M implementation for class A.
        /// </summary>
        public void M()
        {
        }
    }

    /// <summary>
    /// Empty class B.
    /// </summary>
    class B
    {
    }

    ///// <summary>
    ///// Class C that cannot inherit from both A and B directly (commented out due to compilation error).
    ///// </summary>
    //class C : A, B 
    //{
    //    // Class C cannot inherit from both A and B directly.
    //}

    /// <summary>
    /// Empty interface IInterface1.
    /// </summary>
    interface IInterface1
    {
    }

    /// <summary>
    /// Empty interface IInterface2.
    /// </summary>
    interface IInterface2
    {
    }

    /// <summary>
    /// Class C implementing interfaces IInterface1 and IInterface2.
    /// </summary>
    class C : B, IInterface1, IInterface2
    {
    }

    /// <summary>
    /// Class D inheriting from class C.
    /// </summary>
    class D : C
    {
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of class C and class D.
            C cObject = new C();
            D dObject = new D();

            // Output information about class C implementing interfaces IInterface1 and IInterface2.
            Console.WriteLine("C class implements interfaces IInterface1 and IInterface2.");
            Console.WriteLine($"Is C an instance of IInterface1? {cObject is IInterface1}");
            Console.WriteLine($"Is C an instance of IInterface2? {cObject is IInterface2}");

            // Output information about class D inheriting from class C.
            Console.WriteLine("\nD class inherits from C.");
            Console.WriteLine($"Is D an instance of IInterface1? {dObject is IInterface1}");
            Console.WriteLine($"Is D an instance of IInterface2? {dObject is IInterface2}");

            Console.ReadLine();


            #region Interface

            // Intended for describing common behavior.
            // Sometimes used to guarantee the implementation of certain behavior.
            // An interface is an analog of a fully abstract class but allows multiple "inheritance."

            // Interfaces can contain:
            //   Methods
            //   Properties
            //   Indexers
            //   Events

            #endregion

        }
    }
}
