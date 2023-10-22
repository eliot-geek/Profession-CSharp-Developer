namespace _13OverloadingMethodsParams
{
    internal class Program
    {
        /// <summary>
        /// This method takes in a single integer argument and returns that value. It essentially serves as a base case for the other sum methods.
        /// </summary>
        /// <param name="V1"></param>
        /// <returns></returns>
        static int Sum(int V1) 
        { 
            return V1; 
        }

        /// <summary>
        /// This method takes in two integer arguments and returns their sum. It's a straightforward implementation of addition
        /// </summary>
        /// <param name="V1"></param>
        /// <param name="V2"></param>
        /// <returns></returns>
        static int Sum(int V1, int V2) 
        { 
            return V1 + V2; 
        }

        /// <summary>
        /// This method takes in three integer arguments and returns their sum. Again, it's a straightforward implementation of addition
        /// </summary>
        /// <param name="V1"></param>
        /// <param name="V2"></param>
        /// <param name="V3"></param>
        /// <returns></returns>
        static int Sum(int V1, int V2, int V3) 
        { 
            return V1 + V2 + V3; 
        }

        /// <summary>
        /// This method takes in four integer arguments and returns their sum. It follows the same pattern as the previous methods
        /// </summary>
        /// <param name="V1"></param>
        /// <param name="V2"></param>
        /// <param name="V3"></param>
        /// <param name="V4"></param>
        /// <returns></returns>
        static int Sum(int V1, int V2, int V3, int V4) 
        { 
            return V1 + V2 + V3 + V4; 
        }

        /// <summary>
        /// This method takes in five integer arguments and returns their sum. It's similar to the previous methods, but with an additional argument
        /// </summary>
        /// <param name="V1"></param>
        /// <param name="V2"></param>
        /// <param name="V3"></param>
        /// <param name="V4"></param>
        /// <param name="V5"></param>
        /// <returns></returns>
        static int Sum(int V1, int V2, int V3, int V4, int V5) 
        { 
            return V1 + V2 + V3 + V4 + V5; 
        }

        /// <summary>
        /// This method takes in six integer arguments and returns their sum. It follows the same pattern as the previous methods, but with an additional argument
        /// </summary>
        /// <param name="V1"></param>
        /// <param name="V2"></param>
        /// <param name="V3"></param>
        /// <param name="V4"></param>
        /// <param name="V5"></param>
        /// <param name="V6"></param>
        /// <returns></returns>
        static int Sum(int V1, int V2, int V3, int V4, int V5, int V6) 
        { 
            return V1 + V2 + V3 + V4 + V5 + V6; 
        }

        /// <summary>
        /// This method takes in an array of integers and returns their sum. It uses a loop to iterate over the array and add up the values, then returns the result. 
        /// This method allows for more flexibility in the number of arguments that can be passed in, as any number of integers can be added to the array.
        /// </summary>
        /// <param name="Args"></param>
        /// <returns></returns>
        static int Sum(int[] Args)
        {
            int result = 0;             // Initialize a variable to store the sum
            foreach (var e in Args)     // Loop through each integer in the array
            {
                result += e;            // Add the current integer to the sum
            }
            return result;              // Return the final sum
        }

        static void Main(string[] args)
        {
            // The project manager asks you to write a method that will find the sum of an unknown number of integers


            var res = Sum(1);               // Call Sum with a single argument and assign the result to res
            res = Sum(1, 9);                // Call Sum with two arguments and assign the result to res
            res = Sum(1, 9, 9);             // Call Sum with three arguments and assign the result to res
            res = Sum(1, 9, 9, 0);          // Call Sum with four arguments and assign the result to res
            res = Sum(1, 9, 9, 0, 2);       // Call Sum with five arguments and assign the result to res
            res = Sum(1, 9, 9, 0, 2, 8);    // Call Sum with six arguments and assign the result to res


            int[] col = new int[] { 2, 8, 0, 9, 9, 0 };         // Declare an array of integers

            Console.WriteLine(res);                             // Output the value of res to the console
            Console.ReadKey();

            res = Sum(col);                                             // Call Sum with the array and assign the result to res
            res = Sum(new int[] { 2, 8, 0, 9, 9, 0, 0, 1, 3, 5 });      // Call Sum with a longer array and assign the result to res
            Console.WriteLine(res);                                     // Output the value of res to the console
            Console.ReadKey();

            res = Sum(new int[] { 2, 8, 0, 9 });                        // Call Sum with a shorter array and assign the result to res
            Console.WriteLine(res);                                     // Output the value of res to the console
            Console.ReadKey();

            res = Sum(new int[] { 2, 8 });              // Call Sum with an array of length 2 and assign the result to res
            Console.WriteLine(res);                     // Output the value of res to the console
            Console.ReadKey();

            res = Sum(new int[] { 2 });     // Call Sum with an array of length 1 and assign the result to res
            Console.WriteLine(res);         // Output the value of res to the console
            Console.ReadKey();

        }
    }
}