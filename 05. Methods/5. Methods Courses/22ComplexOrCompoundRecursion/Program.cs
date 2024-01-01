namespace _22ComplexOrCompoundRecursion
{
    internal class Program
    {
        /// <summary>
        /// Recursive function named "F" that takes an integer parameter "N". 
        /// calculates the sum of the previous two terms of a sequence starting with N, where the first two terms are 1 and 2.
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        static int F(int N)
        {
            Console.WriteLine($" F{N}");
            return (N > 2) ? F(N - 1) + G(N - 2) : N;
        }

        /// <summary>
        /// Recursive function that takes an integer N as its parameter and returns an integer
        /// G computes a value based on the values of F and G for smaller inputs.
        /// If N is less than or equal to 2, G returns N+1 as the base case. The base case serves as a stopping point for the recursion.
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        static int G(int N)
        {
            Console.WriteLine($" G{N}");
            return (N > 2) ? G(N - 1) + F(N - 2) : N + 1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(F(6));  // 17
            Console.ReadKey();

            /*
            The value of 17 is the result of the recursive function calls in F(6). The sequence of recursive function calls is as follows:

            F(6) calls F(5) and G(4).
            F(5) calls F(4) and G(3).
            F(4) calls F(3) and G(2).
            F(3) returns 3 (because N <= 2).
            G(2) returns 4 (because N <= 2).
            F(4) returns F(3) + G(2) = 3 + 4 = 7.
            G(3) calls G(2) and F(1).
            F(1) returns 1 (because N <= 2).
            G(2) returns 4 (because N <= 2).
            G(3) returns G(2) + F(1) = 4 + 1 = 5.
            F(5) returns F(4) + G(3) = 7 + 5 = 12.
            G(4) calls G(3) and F(2).
            F(2) returns 2 (because N <= 2).
            G(3) returns G(2) + F(1) = 4 + 1 = 5.
            G(4) returns G(3) + F(2) = 5 + 2 = 7.
            F(6) returns F(5) + G(4) = 12 + 7 = 17.

            */


            Console.WriteLine(F(8));
            Console.ReadKey();

            Console.WriteLine(F(13));
            Console.ReadKey();
        }
    }
}
