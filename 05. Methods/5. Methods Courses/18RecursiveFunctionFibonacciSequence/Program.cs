namespace _18RecursiveFunctionFibonacciSequence
{
    internal class Program
    {
        /// <summary>
        /// Recursive function to calculate the Fibonacci sequence
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        static int Fib(int N)
        {
            return (N == 1 || N == 2) ? 1 : Fib(N - 1) + Fib(N - 2);    // using ternary operator for conditional check
        }

        /// <summary>
        /// Iterative function to calculate the Fibonacci sequence using a loop
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        static int FibLoop(int N)
        {
            int a1 = 1;
            int a2 = 1;
            int t = a2;

            for (int i = 2; i < N; i++)
            {
                t = a1 + a2;
                
                a1 = a2;
                a2 = t;
            }
            
            return t; 
        }
        // This is the best in term of ressources (memory)


        static void Main(string[] args)
        {
            // 1  1  2  3  5  8  13  21  34  55
            // fib(1) = 1
            // fib(2) = 1
            // fib(n) = fib(n-1) + fib(n-2), n >= 3

            // Loop through the first 25 numbers in the Fibonacci sequence
            for (int i = 1; i <= 25; i++)
            {
                Console.WriteLine($"Fib({i,2}) = {Fib(i)}    {FibLoop(i)}");  // Print out the ith number in the sequence using both the recursive and iterative functions
            }
        }
    }
}
