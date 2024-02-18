namespace Less09LimitationsGenericsInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate Storage1 with type A
            Storage1<A> storage1 = new Storage1<A>();

            Storage2<B> storage2 = new Storage2<B>();

            Storage3<C> storage3 = new Storage3<C>();
            storage3.Add(new C { Property3 = "SomeValue" });

            Storage5<E> storage5 = new Storage5<E>();


            Console.WriteLine("Storage1: ");
            Console.WriteLine($"Last Property1: {storage1.GetLastProperty()}");

            Console.WriteLine("\nStorage2: ");
            Console.WriteLine($"Last Property2: {storage2.GetLastProperty()}");

            Console.WriteLine("\nStorage3: ");
            Console.WriteLine($"Last Property3: {storage3.GetLastProperty()}");

            Console.WriteLine("\nStorage5: ");
            Console.WriteLine($"Last Property1 + Property2: {storage5.GetLastProperty()}");


            // Errors: Attempting to instantiate storages with incompatible types
            //Storage1<B> storage = new Storage1<B>(); 
            //Storage2<C> storage = new Storage2<C>();
            //Storage3<D> storage = new Storage3<D>();
            //Storage5<D> storage = new Storage5<D>();
            //Storage5<C> storage = new Storage5<C>();
        }
    }
}
