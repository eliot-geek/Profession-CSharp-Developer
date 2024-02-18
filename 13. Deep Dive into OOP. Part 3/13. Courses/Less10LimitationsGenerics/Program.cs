namespace Less10LimitationsGenerics
{
    /// <summary>
    /// Represents a base class.
    /// </summary>
    class A { }

    /// <summary>
    /// Represents a class inheriting from A.
    /// </summary>
    class B : A { }

    /// <summary>
    /// Represents a class inheriting from A.
    /// </summary>
    class C : A { }

    /// <summary>
    /// Represents a class inheriting from A.
    /// </summary>
    class D : A { }

    /// <summary>
    /// Represents a class inheriting from B.
    /// </summary>
    class E : B { }

    /// <summary>
    /// Represents a generic class with three type parameters, where the first type parameter must be a base class of the second type parameter.
    /// </summary>
    class MyClass<T1, T2, T3> where T1 : T2
    {

    }

    /// <summary>
    /// Represents a generic class with three type parameters, where the first type parameter must be a base class of the second type parameter, 
    /// and the third type parameter must be a derived class of the first type parameter.
    /// </summary>
    class MyClass1<T1, T2, T3>
        where T1 : T2
        where T3 : T1
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass<C, A, A> myClass1 = new MyClass<C, A, A>();
            MyClass<E, A, A> myClass2 = new MyClass<E, A, A>();
            MyClass<E, B, C> myClass3 = new MyClass<E, B, C>();

            MyClass1<B, A, E> my = new MyClass1<B, A, E>();    

            MyClass<string, object, int> myClass4 = new MyClass<string, object, int>();
            MyClass<int, object, int> myClass5 = new MyClass<int, object, int>();
            MyClass<int, ValueType, int> myClass6 = new MyClass<int, ValueType, int>();

            MyClass<ValueType, object, int> myClass7 = new MyClass<ValueType, object, int>();

            Console.WriteLine("All instantiations completed successfully.");
        }
    }
}
