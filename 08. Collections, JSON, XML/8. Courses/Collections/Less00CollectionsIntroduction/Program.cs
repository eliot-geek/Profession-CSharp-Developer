namespace Less00CollectionsIntroduction
{
    internal class Program
    {
        /// <summary>
        /// Print
        /// </summary>
        /// <param name="Col"></param>
        /// <param name="Text"></param>
        static void PrintArray(int[] Col, string Text = "")
        {
            Console.WriteLine(Text);
            foreach (var element in Col)
            {
                Console.Write($"{element} ");
            }
        }

        /// <summary>
        /// Delete (Not the best way) 
        /// </summary>
        /// <param name="Col"></param>
        /// <param name="Position"></param>
        /// <returns></returns>
        static bool RemoveAt(ref int[] Col, int Position)
        {
            bool result = false;
            if (Position >= 0 && Position <= Col.Length) 
            {
                // 1 2 3 4 5 - 1 3 4 5 - To remove the '2'
                // We copy the subsequent elements to the left, one position at a time, until we reach the end
                for (int index = 0; index < Col.Length - 1; index++)
                {
                    Col[index] = Col[index + 1];
                }
                Array.Resize(ref Col, Col.Length - 1); // Delete the last one
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        static void Main(string[] args)
        {
            #region Add

            Console.WriteLine("Add");
            var a = new int[] { 1, 1, 2, 3, 5, 8 };
            PrintArray(a, "Source array a: ");
            Array.Resize(ref a, a.Length + 1);
            a[a.Length - 1] = 13;
            PrintArray(a, "\nReceived array a: ");

            #endregion

            #region Delete

            Console.WriteLine("\n\nDelete");
            var b = new int[] { 1, 2, 3, 4, 5, 8, 13 };
            PrintArray(b, "Source array b: ");
            int position = 1;
            if (RemoveAt(ref b, position))
            {
                PrintArray(b, "\nReceived array b: ");
            }
            else
            {
                Console.WriteLine("\nWrong element's index");
            }
            Console.WriteLine();

            #endregion
        }
    }
}