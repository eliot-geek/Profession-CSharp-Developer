namespace _03IfElseStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // To check other conditions, the if statement can be extended with any number of if's. Each additional condition will be checked only if all previous conditions are false.

            // The Random class is a built-in class in C# that allows you to generate random numbers.
            Random rand = new Random();

            // Returns 0, 1, or 2
            int x = rand.Next(3);
            Console.WriteLine($"The value of x is {x}");

            if (x == 1) Console.WriteLine("x = 1");
            else Console.WriteLine("x != 1");

            if (x == 1)
            {
                Console.WriteLine("x = 1");
            }
            else
            {
                Console.WriteLine("x != 1");
            }

            #region if-else-if

            if (x < 1) Console.WriteLine("x < 1");
            else if (x > 1) Console.WriteLine("x > 1");
            else Console.WriteLine("x = 1");

            #endregion

            #region Example 1
            Console.ReadKey();

            if (x < 1)
            {
                Console.WriteLine("x < 1");
            }
            else if (x > 1)
            {
                Console.WriteLine("x > 1");
            }
            else
            {
                Console.WriteLine("x = 1");
            }

            #endregion

            #region Example 2
            Console.ReadKey();

            if (true)
            {

            }
            else
            {
                if (true)
                {

                }
                else
                {
                    if (true)
                    {

                    }
                    else
                    {

                    }
                }
            }

            if (x < 1)
            {
                Console.WriteLine("x < 1");
            }
            else
            {
                if (x > 1)
                {
                    Console.WriteLine("x > 1");
                }
                else
                {
                    Console.WriteLine("x = 1");
                }
            }

            #endregion

        }
    }
}