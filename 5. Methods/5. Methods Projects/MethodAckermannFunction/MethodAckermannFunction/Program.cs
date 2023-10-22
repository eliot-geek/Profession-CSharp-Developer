namespace MethodAckermannFunction
{
    internal class Program
    {
        /// <summary>
        /// A method to make the console close delayed
        /// </summary>
        static void Delay()
        {
            Console.ReadKey();
        }

        /// <summary>
        /// A method to display the message in the console
        /// </summary>
        /// <param name="text"></param>
        static void Print(string text)
        {
            Console.Write(text);
        }

        /// <summary>
        /// Ackerman function
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        static int Ackerman(int n, int m)
        {
            if (n == 0)
                return m + 1;
            if (n != 0 && m == 0)
                return Ackerman(n - 1, 1);
            if (n > 0 && m > 0)
                return Ackerman(n - 1, Ackerman(n, m - 1));
            return Ackerman(n, m);
        }

        /// <summary>
        /// Define the Ackermann function
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static int Ackermann(int n, int m)
        {
            if (n == 0) 
            {
                return m + 1;
            }
            else if (n > 0 && m == 0) 
            {
                return Ackermann(n - 1, 1);
            }
            else
            {
                return Ackermann(n - 1, Ackermann(n, m - 1));
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ackermann function for n = 2, m = 2 is: " + Ackermann(2, 2));
            Console.WriteLine("Ackermann function for n = 1, m = 2 is: " + Ackermann(1, 2));
            Delay();

            /*
            When n = 1 and m = 2, we can apply the Ackermann function as follows:
            A(1, 2) 
            = A(0, A(1, 1))             // using the third case
            = A(0, A(0, A(1, 0)))       // using the third case
            = A(0, A(0, A(0, 1)))       // using the second case
            = A(0, A(0, 2))             // using the second case
            = A(0, 3)                   // using the first case
            = 4                         // using the second case
            
            So the result of the Ackermann function when n = 1 and m = 2 is 4.
            In the above steps, we applied the third case of the Ackermann function repeatedly until we reached the base case of n = 0. 
            Once we reach the base case, we can evaluate the function based on the second or first case. 
            We used the second case in the above steps to evaluate the function for n = 0 and m = 3. Finally, we substituted the results upward to obtain the final result.

            Or just watch the [table of Values](https://en.wikipedia.org/wiki/Ackermann_function#Table_of_values)
            */


            Print("\nCalculate using recursion, Ackerman function\n");
            Print("Enter the number n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            while (!((n >= 0 && n < 4)))
            {
                Print("Error! Not enough memory. Enter 0 <= n < 4.\n");
                Print("Enter the number n: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            Print("Enter the number m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            while (!((m >= 0 && m < 11)))
            {
                Print("Error! Not enough memory. Enter 0 <= m < 11.\n");
                Print("Enter number m: ");
                m = Convert.ToInt32(Console.ReadLine());
            }
            Ackerman(n, m);

            Print("Ackerman function (n, m): ");
            Console.WriteLine(Ackerman(n, m));
            Delay();

            // Reference: https://en.wikipedia.org/wiki/Ackermann_function
            // The Ackermann function is a recursive mathematical function that takes two non-negative integer arguments n and m and returns a non-negative integer value.
            // The function is defined by a set of recursive rules and is notable for being one of the simplest examples of a computable but not primitive recursive function.
            // It grows very quickly as the values of n and m increase, making it a useful tool for analyzing the efficiency of algorithms and computing systems.
        }
    }
}
