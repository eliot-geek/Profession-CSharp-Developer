namespace Less07ExtensionMethods
{
    /// <summary>
    /// A static class containing extension methods for various types.
    /// </summary>
    public static class Ext
    {
        /// <summary>
        /// Prints the value of the object to the console.
        /// </summary>
        /// <typeparam name="T">The type of the object.</typeparam>
        /// <param name="O">The object to print.</param>
        public static void Print<T>(this T O)
        {
            Console.WriteLine(O);
        }

        public static void Print(this double O)
        {
            Console.WriteLine(O);
        }

        /// <summary>
        /// Prints the elements of a list to the console.
        /// </summary>
        /// <typeparam name="T">The type of elements in the list.</typeparam>
        /// <param name="O">The list to print.</param>
        public static void Print<T>(this List<T> O)
        {
            foreach (var e in O)
            {
                Console.Write($"{e} ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Raises an integer to the power of another integer.
        /// </summary>
        /// <param name="A">The base integer.</param>
        /// <param name="B">The exponent integer.</param>
        /// <returns>The result of raising A to the power of B.</returns>
        static public int Pow(this int A, int B)
        {
            return (int)Math.Pow(A, B);
        }

        /// <summary>
        /// Adds an integer to a list of integers.
        /// </summary>
        /// <param name="item">The integer to add to the list.</param>
        /// <param name="Col">The list to which the integer is added.</param>
        static public void AddTo(this int item, List<int> Col)
        {
            Col.Add(item);
        }

        /// <summary>
        /// Adds an item to a list of items.
        /// </summary>
        /// <typeparam name="U">The type of items in the list.</typeparam>
        /// <param name="item">The item to add to the list.</param>
        /// <param name="Col">The list to which the item is added.</param>
        /// <remarks>This method is constrained to value types.</remarks>
        static public void AddTo<U>(this U item, List<U> Col)
            where U : struct
        {
            Col.Add(item);
        }

        /// <summary>
        /// Adds an item to a list of items.
        /// </summary>
        /// <typeparam name="U">The type of items in the list.</typeparam>
        /// <param name="item">The item to add to the list.</param>
        /// <param name="Col">The list to which the item is added.</param>
        public static void AddStringTo<U>(this U item, List<U> Col)
        {
            Col.Add(item);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            var res = Math.Pow(2, 4);
            Console.WriteLine(res);
            Console.ReadLine();

            Math.Pow(2, 4).Print();
            Console.ReadLine();


            2.Pow(4).Print();
            Console.ReadLine();


            // Prints the elements of a list.
            List<int> d = new List<int>() { 1, 2, 3, 4, 5, 6 };
            d.Print();
            Console.ReadLine();


            // Prints the value of an integer.
            int a = 0;
            a.Print();
            Console.ReadLine();


            // Prints the elements of the list after adding a new element.
            2.Pow(4).AddTo(d);
            d.Print();
            Console.ReadLine();


            string str = "qwe";
            List<string> vs = new List<string>();
            
            // str.AddTo(vs);  // You can use this but you have to comments this part (where U : struct)
            
            str.AddStringTo(vs);
            vs.Print();
        }
    }
}
