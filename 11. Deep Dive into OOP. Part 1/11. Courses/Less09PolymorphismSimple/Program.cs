namespace Less09PolymorphismSimple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of class A and calling its method M.
            A a = new A();
            Console.WriteLine("A a = new A(); a.M(); ");
            a.M();


            // Creating an instance of class B and calling its method M.
            B b = new B();
            Console.WriteLine("B b = new B(); b.M(); ");
            b.M();


            // Assigning an instance of class B to a variable of type A and calling its method M.
            a = new B();
            Console.WriteLine("A a = new B(); a.M(); ");
            a.M();

            Console.ReadLine();


            #region Classes C and D

            Console.WriteLine();

            // Calls method M on an instance of class C.
            C c = new C();
            Console.WriteLine("C c = new C(); c.M();  "); 
            c.M();


            // Calls method M on an instance of class D.
            D d = new D();
            Console.WriteLine("D d = new D() d.M();  "); 
            d.M();


            // Calls method M on an instance of class D assigned to a variable of type C.
            c = new D();
            Console.WriteLine("c = new D(); c.M();  "); 
            c.M(); 

            #endregion
        }
    }
}
