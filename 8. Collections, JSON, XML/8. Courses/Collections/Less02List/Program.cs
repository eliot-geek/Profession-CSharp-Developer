namespace Less02List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region List<T>

            // Add - Adds an object to the end
            // AddRange - Adds the elements of a specified collection to the end of the list
            // Remove - Removes the first occurrence of the specified object from the collection
            // RemoveAt - Removes the element at the specified index from the list
            // Contains - Determines whether an element is in the collection
            // IndexOf - Searches for the specified object and returns the zero-based index of the first occurrence found within the entire list
            // LastIndexOf - Searches for the specified object and returns the zero-based index of the last occurrence found within the entire list
            // [] - Gets or sets the element at the specified index
            // Insert - Inserts an element into the collection at the specified index
            // Count - Gets the number of elements contained in the collection
            // Clear - Removes all elements from the collection
            // Sorting the list
            // Sort or Sort(comparison_function)
            // Reverse

            #endregion

            List<int> list = new List<int>();
            //List<int> list = new List<int>() { 1, 2, 3, 5, 6, };
            list.Add(1);
            list.Add(2);
            list[1] = 11;

            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]} ");
            }

            list.Sort();
            Console.WriteLine("\nSorted list");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]} ");
            }
            Console.WriteLine();

            // SortedList<> - similar to List<> but sorted by default
        }
    }
}