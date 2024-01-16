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

            // List<T> is a dynamic array in C# that provides various methods for manipulating the collection.


            // Add - Adds an object to the end
            List<int> list = new List<int>();
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
            Console.WriteLine("\n\nSorted list");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]} ");
            }
            Console.WriteLine();


            // AddRange - Adds the elements of a specified collection to the end of the list
            List<int> additionalList = new List<int>() { 20, 21, 22 };
            list.AddRange(additionalList);
            Console.WriteLine("\nList after AddRange:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]} ");
            }
            Console.WriteLine();


            // Remove - Removes the first occurrence of the specified object from the collection
            list.Remove(5);
            Console.WriteLine("\nList after Remove(5):");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]} ");
            }
            Console.WriteLine();

            // RemoveAt - Removes the element at the specified index from the list
            list.RemoveAt(3);
            Console.WriteLine("\nList after RemoveAt(3):");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]} ");
            }
            Console.WriteLine();


            // Contains - Determines whether an element is in the collection
            bool contains = list.Contains(7);
            Console.WriteLine($"\nList {(contains ? "contains" : "does not contain")} 7");
            Console.WriteLine();

            // IndexOf - Searches for the specified object and returns the zero-based index of the first occurrence found within the entire list
            int indexOfSeven = list.IndexOf(7);
            Console.WriteLine($"Index of first occurrence of 7: {indexOfSeven}");
            Console.WriteLine();

            // LastIndexOf - Searches for the specified object and returns the zero-based index of the last occurrence found within the entire list
            int lastIndexOfSeven = list.LastIndexOf(7);
            Console.WriteLine($"Index of last occurrence of 7: {lastIndexOfSeven}");
            Console.WriteLine();

            // [] - Gets or sets the element at the specified index
            Console.WriteLine($"Element at index 2: {list[2]}");
            list[2] = 99;
            Console.WriteLine("List after setting element at index 2 to 99:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]} ");
            }
            Console.WriteLine();

            // Insert - Inserts an element into the collection at the specified index
            list.Insert(4, 42);
            Console.WriteLine("\nList after Insert(4, 42):");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]} ");
            }
            Console.WriteLine();

            // Count - Gets the number of elements contained in the collection
            Console.WriteLine($"\nNumber of elements in the list: {list.Count}");
            Console.WriteLine();

            // Clear - Removes all elements from the collection
            list.Clear();
            Console.WriteLine("List after Clear:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]} ");
            }
            Console.WriteLine();

            // Sorting the list
            list.AddRange(new List<int>() { 5, 2, 8, 1, 3 });
            Console.WriteLine("\nList before sorting:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]} ");
            }
            Console.WriteLine();

            list.Sort();
            Console.WriteLine("\nList after sorting in ascending order:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]} ");
            }
            Console.WriteLine();

            // Reverse
            list.Reverse();
            Console.WriteLine("\nList after reversing:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]} ");
            }
            Console.WriteLine();


            // SortedList<> - similar to List<> but sorted by default

            // Create a SortedList with integers as keys and strings as values
            SortedList<int, string> sortedList = new SortedList<int, string>();

            // Add elements to the SortedList
            sortedList.Add(3, "Three");
            sortedList.Add(1, "One");
            sortedList.Add(2, "Two");
            sortedList.Add(4, "Four");

            // Display the elements in the sorted order
            Console.WriteLine("\nSorted List:");

            foreach (var pair in sortedList)
            {
                Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
            }

            // Access elements by key
            int keyToAccess = 2;
            Console.WriteLine($"\nValue at key {keyToAccess}: {sortedList[keyToAccess]}");
            Console.WriteLine();

            // Remove an element
            int keyToRemove = 1;
            sortedList.Remove(keyToRemove);

            // Display the elements after removal
            Console.WriteLine($"\nSorted List after removing key {keyToRemove}:");

            foreach (var pair in sortedList)
            {
                Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
            }
            Console.WriteLine();

        }
    }
}