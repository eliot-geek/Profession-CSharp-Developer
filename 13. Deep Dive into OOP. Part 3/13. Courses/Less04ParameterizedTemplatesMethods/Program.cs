namespace Less04ParameterizedTemplatesMethods
{
    internal class Program
    {
        #region Parameterized With Methods

        /// <summary>
        /// Swaps two integer values.
        /// </summary>
        /// <param name="A">The first integer value to swap.</param>
        /// <param name="B">The second integer value to swap.</param>
        static void Swap(ref int A, ref int B)
        {
            int c = A;
            A = B;
            B = c;
        }

        /// <summary>
        /// Swaps two arrays of double values.
        /// </summary>
        /// <param name="A">The first array of double values to swap.</param>
        /// <param name="B">The second array of double values to swap.</param>
        static void Swap(ref double[] A, ref double[] B)
        {
            double[] c = A;
            A = B;
            B = c;
        }

        /// <summary>
        /// Swaps two arrays of byte values.
        /// </summary>
        /// <param name="A">The first array of byte values to swap.</param>
        /// <param name="B">The second array of byte values to swap.</param>
        static void Swap(ref byte[] A, ref byte[] B)
        {
            byte[] c = A;
            A = B;
            B = c;
        }

        #endregion


        #region Parameterized With Templates

        /// <summary>
        /// Generic method to swap two values of the same type.
        /// </summary>
        /// <typeparam name="T">The type of the values to swap.</typeparam>
        /// <param name="A">The first value to swap.</param>
        /// <param name="B">The second value to swap.</param>
        static void Swap<T>(ref T A, ref T B)
        {
            T c = A;
            A = B;
            B = c;
        }

        #endregion

        static void Main(string[] args)
        {
            #region Parameterized Methods

            int a = 1, b = 2;
            Console.WriteLine($"a = {a} b = {b} ");

            Swap(ref a, ref b);
            
            Console.WriteLine($"a = {a} b = {b} ");
            Console.WriteLine();


            double[] x = { 1.1, 2.3, 4.5 };
            double[] y = { 6.7, 8.9, 10 };
            Console.Write("x: ");
            foreach (var e in x)
            {
                Console.Write($"{e,3} ");
            }
            Console.Write("y: ");
            foreach (var e in y)
            {
                Console.Write($"{e,3} ");
            }
            Console.WriteLine();

            Swap(ref x, ref y);
            
            Console.Write("x: ");
            foreach (var e in x)
            {
                Console.Write($"{e,3} ");
            }
            Console.Write("y: ");
            foreach (var e in y)
            {
                Console.Write($"{e,3} ");
            }
            Console.WriteLine();


            byte[] k = { 1, 2, 4 };     // If we change the data type from byte to int, it will not work correctly.
            byte[] l = { 6, 8, 10 };
            Console.Write("k: ");
            foreach (var e in k)
            {
                Console.Write($"{e,3} ");
            }
            Console.Write("l: ");
            foreach (var e in l)
            {
                Console.Write($"{e,3} ");
            }
            Console.WriteLine();

            Swap(ref k, ref l);
            
            Console.Write("k: ");
            foreach (var e in k)
            {
                Console.Write($"{e,3} ");
            }
            Console.Write("l: ");
            foreach (var e in l)
            {
                Console.Write($"{e,3} ");
            }
            Console.WriteLine();

            #endregion



            #region Parameterized With Templates (Better Approach: This method allows us to work with any data type effortlessly)

            Console.WriteLine("\n------------------------------\n");

            int c = 1, d = 2;
            Console.WriteLine($"c = {c} d = {d} ");
            
            Swap<int>(ref c, ref d);
            
            Console.WriteLine($"c = {c} d = {d} ");
            Console.WriteLine();


            double[] p = { 1.1, 2.3, 4.5 };
            double[] q = { 6.7, 8.9, 10 };
            Console.Write("p: ");
            foreach (var e in p)
            {
                Console.Write($"{e,3} ");
            }
            Console.Write("q: ");
            foreach (var e in q)
            {
                Console.Write($"{e,3} ");
            }
            Console.WriteLine();

            Swap<double[]>(ref p, ref q);
            
            Console.Write("p: ");
            foreach (var e in p)
            {
                Console.Write($"{e,3} ");
            }
            Console.Write("q: ");
            foreach (var e in q)
            {
                Console.Write($"{e,3} ");
            }
            Console.WriteLine();


            byte[] m = { 1, 2, 4 };     // If we change the data type from byte to int, it will not function correctly.
            byte[] n = { 6, 8, 10 };
            Console.Write("m: ");
            foreach (var e in m)
            {
                Console.Write($"{e,3} ");
            }
            Console.Write("n: ");
            foreach (var e in n)
            {
                Console.Write($"{e,3} ");
            }
            Console.WriteLine();

            Swap<byte[]>(ref m, ref n);
            
            Console.Write("m: ");
            foreach (var e in m)
            {
                Console.Write($"{e,3} ");
            }
            Console.Write("n: ");
            foreach (var e in n)
            {
                Console.Write($"{e,3} ");
            }
            Console.WriteLine();

            #endregion


            #region Better Approach: This method allows us to work with any data type effortlessly.

            Console.WriteLine("\n------------------------------\n");
            
            Swap<int>(ref a, ref b);
            
            Console.WriteLine($"a = {a} b = {b} ");
            Console.WriteLine();

            Swap<byte[]>(ref k, ref l);
            
            Console.Write("k: ");
            foreach (var e in k)
            {
                Console.Write($"{e,3} ");
            }
            Console.Write("l: ");
            foreach (var e in l)
            {
                Console.Write($"{e,3} ");
            }
            Console.ReadLine();

            #endregion
        }
    }
}
