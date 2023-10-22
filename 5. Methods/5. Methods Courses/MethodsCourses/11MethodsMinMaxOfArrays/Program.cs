namespace _11MethodsMinMaxOfArrays
{
    internal class Program
    {
        /// <summary>
        /// A method to delay console closure by Interval seconds 
        /// </summary>
        /// <param name="Interval">Number of seconds until the console closes</param>
        static void Pause(int Interval)
        {
            Thread.Sleep(Interval * 1000);
        }

        /// <summary>
        /// A method that fills the Col array
        /// </summary>
        /// <param name="Col">An array of integers to be filled</param>
        static void Fill(int[] Col)
        {
            Random r = new Random();
            for (int i = 0; i < Col.Length; i++)
            {
                Col[i] = r.Next(100);
            }
        }

        /// <summary>
        /// Method, Col array outputs to the console
        /// </summary>
        /// <param name="Col">An array of integers to be output to the console</param>
        static void Print(int[] Col)
        {
            Random r = new Random();
            for (int i = 0; i < Col.Length; i++)
            {
                Console.Write($"{Col[i]} ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Method for finding the maximum value in an array
        /// </summary>
        /// <param name="Col">An array of integers in which you want to find the maximal element</param>
        /// <returns>Maximum value in the array</returns>
        static int Max(int[] Col)
        {
            // Check if the input array is empty
            if (Col.Length < 0) 
                return -1;

            // Initialize the local maximum variable to the first element of the array
            int localMax = Col[0];

            // Iterate through the array, comparing each element to the local maximum.
            // If the element is greater than the local maximum, update the local maximum to the element.
            for (int i = 1; i < Col.Length; i++)
            {
                if (Col[i] > localMax) 
                    localMax = Col[i];
            }
            // Return the local maximum.
            return localMax;
        }

        /// <summary>
        /// Method for finding the minimum value in an array
        /// </summary>
        /// <param name="Col">An array of integers in which you need to find the minimum element</param>
        /// <returns>Minimum value in the array</returns>
        static int Min(int[] Col)
        {
            // Check if the input array is empty or null
            if (Col.Length <= 0) 
                return -1;

            // Initialize the local minimum variable to the first element of the array
            int localMin = Col[0];

            // Iterate through the array, comparing each element to the local minimum
            // If the element is less than the local minimum, update the local minimum to the element
            for (int i = 1; i < Col.Length; i++)
            {
                if (Col[i] < localMin) 
                    localMin = Col[i];
            }
            // Return the local minimum
            return localMin;
        }

        static void Main(string[] args)
        {
            Random r = new Random();                        // Create a new instance of the Random class.
            int N = r.Next(10, 20);                         // Generate a random integer between 10 and 20 (inclusive) and store it in N.
            int[] arr = new int[N];                         // Create a new integer array with N elements.
            Fill(arr);                                      // Fill the array with random integer values using the Fill method.
            Print(arr);                                     // Print the array to the console using the Print method.
            Console.WriteLine($"maxArr = {Max(arr)}");      // Print the maximum value in the array using the Max method.
            Console.WriteLine($"minArr = {Min(arr)}\n");    // Print the minimum value in the array using the Min method.


            int M = r.Next(10, 20);
            int[] brr = new int[M];
            Pause(5);
            Fill(brr);
            Print(brr);
            Console.WriteLine($"maxBrr = {Max(brr)}");
            Console.WriteLine($"minBrr = {Min(brr)}\n");

            //Fill(brr, Count);
            //Fill(brr, Count) takes an integer argument Count that specifies the number of elements in the brr array to fill with random integer values.

            //Fill(brr, Count, BottomRange, UpperRange);
            //Fill(brr, Count, BottomRange, UpperRange) takes three integer arguments: Count, BottomRange, and UpperRange.
            //Count specifies the number of elements in the brr array to fill with random integer values. BottomRange and UpperRange specify the range of
            //possible values for the random integers. The BottomRange value is inclusive, meaning it is a possible value that can be generated, while the
            //UpperRange value is exclusive, meaning it is not a possible value that can be generated.

            //For example, if you called Fill(brr, 10, 1, 6), the brr array would be filled with 10 random integer values between 1 and 5 (inclusive).

            #region Important
            // The method signature is the set of types that the method returns and takes as parameters.
            // int int[]
            // void int[]
            // void int
            // void string[]
            // string void (if there is nothing)
            #endregion

        }
    }
}