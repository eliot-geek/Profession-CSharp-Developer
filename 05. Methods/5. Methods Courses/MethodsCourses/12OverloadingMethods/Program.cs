namespace _12OverloadingMethods
{
    internal class Program
    {
        /// <summary>
        /// The method that fills the array Col
        /// </summary>
        /// <param name="Col">An array of integers to fill</param>
        static void Fill(int[] Col)
        {
            Random r = new Random();
            for (int i = 0; i < Col.Length; i++)
            {
                Col[i] = r.Next(100);
            }
        }

        /// <summary>
        /// The method that fills the first Count elements of the array Col
        /// </summary>
        /// <param name="Col">The array of integers to be filled</param>
        /// <param name="Count">Number of elements to change</param>
        static void Fill(int[] Col, int Count)
        {
            Random r = new Random();
            for (int i = 0; i < Count; i++)
            {
                Col[i] = r.Next(100);
            }
        }

        /// <summary>
        /// A method that fills the first Count elements of the Col array with numbers from the BottomRange UpperRange.
        /// BottomRange must be strictly smaller than the UpperRange
        /// </summary>
        /// <param name="Col">An array of integers to fill</param>
        /// <param name="Count">Number of elements to change</param>
        /// <param name="BottomRange">Lower boundary of the range</param>
        /// <param name="UpperRange">Higher range limit</param>
        static void Fill(int[] Col, int Count, int BottomRange, int UpperRange)
        {
            Random r = new Random();
            for (int i = 0; i < Count; i++)
            {
                Col[i] = r.Next(BottomRange, UpperRange);
            }
        }

        /// <summary>
        /// A method that fills elements of the Col array with numbers from the BottomRange UpperRange.
        /// BottomRange must be strictly smaller than the UpperRange
        /// </summary>
        /// <param name="Col">An array of integers to fill</param>
        /// <param name="BottomRange">BottomRange</param>
        /// <param name="UpperRange">Upper range limit</param>
        static void Fill(int[] Col, int BottomRange, int UpperRange)
        {
            Random r = new Random();
            for (int i = 0; i < Col.Length; i++)
            {
                Col[i] = r.Next(BottomRange, UpperRange);
            }
        }

        /// <summary>
        /// A method that fills elements of the Col array with numbers from the BottomRange UpperRange.
        /// BottomRange must be strictly smaller than the UpperRange
        /// </summary>
        /// <param name="Col">An array of integers to fill</param>
        /// <param name="BottomRange">Lower boundary of the range</param>
        /// <param name="UpperRange">Upper limit of the range</param>
        static void Fill(double[] Col, int BottomRange, int UpperRange)
        {
            Random r = new Random();
            for (int i = 0; i < Col.Length; i++)
            {
                Col[i] = r.Next(BottomRange, UpperRange);
            }
        }

        /// <summary>
        /// The method that outputs the array Col to the console
        /// </summary>
        /// <param name="Col">An array of integers to output to the console</param>
        static void Print(int[] Col)
        {
            Random r = new Random();
            for (int i = 0; i < Col.Length; i++)
            {
                Console.Write($"{Col[i],3}");
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            #region Method overloading
            // Method overloading is a set of methods with the same name, but with a different number or type of formal parameters
            #endregion

            int[] arr = new int[20];

            Fill(arr, 10);              // static void Fill(int[] Col, int Count)
            Print(arr);
            Console.ReadKey();

            Fill(arr);                  // static void Fill(int[] Col)
            Print(arr);
            Console.ReadKey();

            Fill(arr, -10, 0);          // static void Fill(int[] Col, int BottomRange, int UpperRange)
            Print(arr);
            Console.ReadKey();

            Fill(arr, 10, 1, 30);       // static void Fill(int[] Col, int Count, int BottomRange, int UpperRange)
            Print(arr);
            Console.ReadKey();

        }
    }
}