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
            // initialize first two numbers
            int a1 = 1;
            int a2 = 1;
            // initialize third number
            int t = a2;

            // starting the loop from 2 because first two numbers are already initialized
            for (int i = 2; i < N; i++)
            {
                // Calculate the next number in the sequence
                t = a1 + a2;

                // Shift the values of a1 and a2 to prepare for the next iteration
                a1 = a2;
                a2 = t;
            }
            return t; // returning the nth Fibonacci number
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