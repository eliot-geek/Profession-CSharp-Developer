namespace _16RecursiveFunction
{
    internal class Program
    {
        /// <summary>
        /// Define a void method named Method1 without any parameters
        /// </summary>
        static void Method1() 
        {
            Console.WriteLine("Recursive Function");
        }

        /// <summary>
        /// Define a void method named Method2 without any parameters which calls the Method1
        /// </summary>
        static void Method2()
        {
            Method1();
        }

        /// <summary>
        /// Entry point of the program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // 5.4 The concept of a recursive function

            // Invoke the Method2 to test the concept of recursive function which is calling a function that calls another function
            Method2();      // Recursive Function
        }
    }
}