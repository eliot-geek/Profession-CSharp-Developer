namespace Less00CollectionsIntroduction
{
    internal class Program
    {
        /// <summary>
        /// Prints the elements of an integer array.
        /// </summary>
        /// <param name="Col">The integer array to be printed.</param>
        /// <param name="Text">Optional text to be displayed before the array elements.</param>
        static void PrintArray(int[] Col, string Text = "")
        {
            Console.WriteLine(Text);

            foreach (var element in Col)
            {
                Console.Write($"{element} ");
            }
        }

        /// <summary>
        /// Deletes an element from an integer array at the specified position.
        /// </summary>
        /// <param name="Col">The integer array from which an element will be removed.</param>
        /// <param name="Position">The position of the element to be removed.</param>
        /// <returns>Returns true if the removal is successful, false otherwise.</returns>
        static bool RemoveAt(ref int[] Col, int Position)
        {
            bool result = false;

            // Check if the specified position is valid
            if (Position >= 0 && Position <= Col.Length) 
            {
                // 1 2 3 4 5 - 1 3 4 5 - To remove the '2'
                // To remove an element at the specified position, copy subsequent elements to the left
                // one position at a time until reaching the end of the array
                for (int index = 0; index < Col.Length - 1; index++)
                {
                    Col[index] = Col[index + 1];
                }

                // Resize the array to remove the last element
                Array.Resize(ref Col, Col.Length - 1);

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
            var array = new int[] { 1, 1, 2, 3, 5, 8 };
            PrintArray(array, "Source array a: ");
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = 13;
            PrintArray(array, "\nReceived array a: ");
            Console.ReadKey();

            #endregion

            #region Delete

            Console.WriteLine("\n\nDelete");
            var arrayb = new int[] { 1, 2, 3, 4, 5, 8, 13 };
            PrintArray(arrayb, "Source array b: ");
            int position = 1;
            if (RemoveAt(ref arrayb, position))
            {
                PrintArray(arrayb, "\nReceived array b: ");
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