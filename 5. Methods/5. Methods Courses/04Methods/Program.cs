namespace _04Methods
{
    internal class Program
    {
        /// <summary>
        /// A method to make the console close delay
        /// </summary>
        static void Delay()
        {
            Console.ReadKey();
        }

        /// <summary>
        /// A method for displaying the "Hello World" message in the console
        /// </summary>
        static public void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }

        /// <summary>
        /// A method to display the message in the console
        /// </summary>
        /// <param name="Text">Message Text</param>
        static void Print(string Text)
        {
            Console.WriteLine(Text);
        }

        static void Main(string[] args)
        {
            #region Theory

            // A method can be created within a class, 
            // Common structure 
            //
            // LevelsAccess ModifiersAccess ReturnType NameMethod(ParametersMethod)
            // {
            //      Method body
            //      return
            // }
            //
            // Access levels: public, protected, internal, private. 
            // With the help of four access modifiers, six accessibility levels can be declared.
            //
            // Access modifiers: static, abstract, async, extern, override, virtual
            //
            // ReturnableType: int, double, string, etc.
            //                 void if there is no need to return anything
            //
            // NameMethod: lowercase and uppercase letters of Roman alphabet, figures, _
            //             a numeral can not occupy the first place
            //
            // ParametersMethod: arguments which, as a rule, are subjected to some actions
            //                  Formal parameters - parameters specified in the method description
            //                  Actual parameters - parameters that are specified when calling the method
            //
            // Naming convention for methods - descriptive name for each word starts with a capital letter.
            //
            // Method call:
            // Write a method name and specify the actual parameters, if any

            #endregion

            // Example 1. Calling the void HelloWorld() method
            HelloWorld();

            // Example 2. Calling the void Print(string Text) method
            Print("Text in the console");

            // Example 3. Calling the void Delay() method
            Delay();
        }
    }
}