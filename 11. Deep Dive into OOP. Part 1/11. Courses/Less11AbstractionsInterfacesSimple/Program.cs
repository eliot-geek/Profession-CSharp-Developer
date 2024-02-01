namespace Less11AbstractionsInterfacesSimple
{
    /// <summary>
    /// Abstract class A with an abstract method M.
    /// </summary>
    abstract class A
    {
        /// <summary>
        /// Abstract method M.
        /// </summary>
        public abstract void M();
    }

    /// <summary>
    /// Class B derived from abstract class A, providing an implementation for method M.
    /// </summary>
    class B : A
    {
        /// <summary>
        /// Overrides the abstract method M with a specific implementation.
        /// </summary>
        public override void M()
        {
            Console.WriteLine("public override void M()");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.M(); // Calls the overridden method in class B.

            A a = new B();
            a.M(); // Calls the overridden method in class B, even though the reference is of type A.

            Console.ReadLine();
        }
    }
}
