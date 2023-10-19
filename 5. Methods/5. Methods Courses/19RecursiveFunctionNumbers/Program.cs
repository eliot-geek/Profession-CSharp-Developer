namespace _19RecursiveFunctionNumbers
{
    internal class Program
    {
        /// <summary>
        /// The method takes an integer n as input and returns a string of its individual digits. 
        /// Recursion to split a natural number into its individual digits and output them one by one 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static string Numbers(int n)
        {
            return n < 10 ? n.ToString() : $"{n % 10} {Numbers(n / 10)}";   // reverse order
            //return n < 10 ? n.ToString() : $"{Numbers(n / 10)} {n % 10} "; // non reverse order
        }

        static void Main(string[] args)
        {
            // Output all digits of the natural number N one by one
            Console.WriteLine(Numbers(1234654));
            Console.WriteLine(Numbers(9));
        }
    }
}
