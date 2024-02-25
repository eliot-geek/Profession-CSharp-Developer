namespace Less02DelegateSomething
{
    #region ToDo

    /// <summary>
    /// Delegate representing a method with no parameters and no return value.
    /// </summary>
    // void, void
    delegate void DelegateName1();

    /// <summary>
    /// Delegate representing a method with a single string parameter and no return value.
    /// </summary>
    // void, string
    delegate void DelegateName2(string Message);

    /// <summary>
    /// Delegate representing a method with a single double parameter and returning a double.
    /// </summary>
    // double, double
    delegate double DelegateName3(double Args);

    #endregion

    internal class Program
    {
        /// <summary>
        /// Method with no parameters and no return value.
        /// </summary>
        // void, void
        static void Something1() 
        { 
            Console.WriteLine("Something method"); 
        }

        /// <summary>
        /// Method with a single string parameter and no return value.
        /// </summary>
        /// <param name="Msg">The message to be displayed.</param>
        // void, string
        static void Something2(string Msg) 
        { 
            Console.WriteLine(Msg); 
        }

        /// <summary>
        /// Method with a single double parameter and returning a double.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>The result of the computation.</returns>
        // double, double
        static double Something3(double x) 
        { 
            return x + 10; 
        }

        static void Main(string[] args)
        {
            var r1 = Something1; Console.WriteLine(r1);
            var r2 = Something2; Console.WriteLine(r2);
            var r3 = Something3; Console.WriteLine(r3);
            Console.ReadLine();

            #region ToDo

            // Using explicit instantiation of delegate variables

            DelegateName1 delegateVarible1 = new DelegateName1(Something1);
            DelegateName2 delegateVarible2 = new DelegateName2(Something2);
            DelegateName3 delegateVarible3 = new DelegateName3(Something3);

            delegateVarible1();                         // Invoke the delegate
            delegateVarible2("Hello World!");           // Invoke the delegate with a parameter
            Console.WriteLine(delegateVarible3(5.5));   // Invoke the delegate with a parameter and capture the result


            // Using method group conversion
            DelegateName1 delegateVar1 = Something1;
            Something1();
            delegateVar1();

            DelegateName2 delegateVar2 = Something2;
            Something2("String");
            delegateVar2("String");

            DelegateName3 delegateVar3 = Something3;
            var res = Something3(2.5);
            Console.WriteLine(res);
            res = delegateVar3(2.5);
            Console.WriteLine(res);

            #endregion


            #region Definitions

            /*
            1. A delegate is a "variable" that stores a reference to a method:
               - A delegate in C# is a type-safe function pointer. It represents a reference to a method with a particular signature. 
            This allows methods to be passed around as parameters or stored as data within a program. Delegates enable powerful features like callback methods and event handling.

            2. Method signature — the type returned by the method and a list of parameter types that can be passed when calling the method:
               - A method's signature consists of its return type and the types of its parameters. It uniquely identifies a method within a class. 
            This information determines the method's compatibility with delegates or other methods expecting a similar signature.

            3. A delegate is the address of a method in memory that has the same signature as the delegate, allowing it to be called safely:
               - A delegate encapsulates a reference to a method. It provides a way to call the method through the delegate instance, abstracting away the specifics of the method's location in memory. 
            By ensuring the method signature matches, delegates enable type-safe invocation of methods, promoting code reliability and safety.
            

            https://stackoverflow.com/questions/8808703/method-signature-in-c-sharp

            */
            
            #endregion
        }
    }
}
