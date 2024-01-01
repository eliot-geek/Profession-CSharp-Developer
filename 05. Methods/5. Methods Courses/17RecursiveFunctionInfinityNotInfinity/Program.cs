namespace _17RecursiveFunctionInfinityNotInfinity
{
    internal class Program
    {
        /// <summary>
        /// A recursive function that will continue to call itself until it reaches stack overflow
        /// </summary>
        static void Infinity()
        {
            Console.Write("O_- ");
            Thread.Sleep(100);      // pauses for 100 milliseconds (0.1 seconds)  
            Infinity();             // Call the function recursively
        }

        /// <summary>
        /// A recursive function that will stop after a certain number of iterations
        /// </summary>
        /// <param name="Count"></param>
        static void NotInfinity(int Count)
        {
            Console.Write("O_- ");          // This function prints "O_- " 
            Thread.Sleep(100);              // Sleeps for 100ms
            Count = Count - 1;              // Then it decrements the Count by 1 
            
            if (Count > 0)                  // Checks if it is greater than 0
                NotInfinity(Count);         // If it is, it calls itself recursively with the new Count value.
        }

        static void Main(string[] args)
        {
            //Infinity();                 // Call Infinity function, which will result in a stack overflow error
            NotInfinity(20);     // Call NotInfinity function, which will stop after a certain number of iterations
        }

    }
}
