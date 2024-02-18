namespace Less08LimitationsStorages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Storage for different types

            Storage<A> storageA = new Storage<A>();
            Storage<B> storageB = new Storage<B>();
            Storage<C> storageC = new Storage<C>();
            Storage<D> storageD = new Storage<D>();
            Storage<E> storageE = new Storage<E>();
            Storage<F> storageF = new Storage<F>();


            // This line will cause a compilation error since int does not derive from A
            //Storage<int> storageInt = new Storage<int>();


            // Add some elements to each storage
            //storageA.Add(new A() { Property = 10 });    // Class A is declared as abstract, meaning it cannot be directly instantiated.
                                                        // Abstract classes are intended to be used as base classes and cannot be instantiated on their own.
            
            storageB.Add(new B() { Property = 20 });
            storageC.Add(new C() { Property = 30 });
            storageD.Add(new D() { Property = 40 });
            storageE.Add(new E() { Property = 50 });
            storageF.Add(new F() { Property = 60 });


            Console.WriteLine($"Last property value in storageB: {storageB.GetLastProperty()}");
            Console.WriteLine($"Last property value in storageC: {storageC.GetLastProperty()}");
            Console.WriteLine($"Last property value in storageD: {storageD.GetLastProperty()}");
            Console.WriteLine($"Last property value in storageE: {storageE.GetLastProperty()}");
            Console.WriteLine($"Last property value in storageF: {storageF.GetLastProperty()}");
        }
    }
}
