namespace Less07HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region HashSet

            // In a HashSet<T>, duplicate elements are not allowed. It automatically removes those duplicates, and it only retains unique elements.
            // Each element in a HashSet must be unique, and the set will not store duplicate values.

            // Add - Adds the specified element to the collection.
            // Remove - Removes the specified element from the collection.
            // Contains - Determines if the collection contains the specified element.
            // UnionWith - Modifies the current object to contain all elements that are in either the current object or the specified collection, or both.
            // IntersectWith - Modifies the current object to contain only the elements that are in both the current object and the specified collection.
            // ExceptWith - Removes all elements in the specified collection from the current object.
            // IsSubSetOf - Determines if the object is a subset of the specified collection.
            // IsSuperSetOf - Determines if the object is a superset of the specified collection.
            // IsProperSubSetOf - Determines if the object is a proper subset of the specified collection.
            // IsProperSuperSetOf - Determines if the object is a proper superset of the specified collection.

            #endregion

            // Each element in a HashSet must be unique, and the set will not store duplicate values
            HashSet<int> set1 = new HashSet<int>(new int[] { 1, 1, 1, 1, 1, 1, 2, 3, 4, 5, 6, 7, 6, 6, 6, 9, 9, 9 });

            // Iterate over set1 using foreach
            Console.WriteLine("Set1: ");
            foreach (var item in set1)
            {
                Console.Write($"{item} ");
            }

            // Contains - Determines whether a specific element is in the set
            Console.WriteLine($"\n\nElement '3' exists in set1 : {set1.Contains(3)}");
            Console.WriteLine($"Element '20' exists in set1 : {set1.Contains(20)}");

            // Create and iterate over set2
            Console.WriteLine("\nSet 2: ");
            HashSet<int> set2 = new HashSet<int>() { 1, 3, 5, 7, 8, 9, 11, 15 };
            foreach (var item in set2)
            {
                Console.Write($"{item} ");
            }

            // UnionWith - Modifies the current set to contain all elements present in itself and the specified collection
            set1.UnionWith(set2);
            Console.WriteLine("\n\nSet1 after the union with set2 : ");
            foreach (var item in set1)
            {
                Console.Write($"{item} ");
            }

            // ExceptWith - Removes all elements in the specified collection from the current set
            set1.ExceptWith(new int[] { 3, 5, 15 });
            Console.WriteLine("\n\nSet1 after ExceptWith(new int[] { 3, 5, 15} : ");
            foreach (var item in set1)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();


            // Add - Adds the specified element to the collection.
            set1.Add(10);
            Console.WriteLine("\nSet1 after set1.Add(10)");
            foreach (var item in set1)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            // Remove - Removes the specified element from the collection.
            set1.Remove(7);
            Console.WriteLine("\nSet1 after set1.Remove(7)");
            foreach (var item in set1)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            // IntersectWith - Modifies the current object to contain only the elements that are in both the current object and the specified collection.
            set1.IntersectWith(new int[] { 1, 9, 8 });
            Console.WriteLine("\n\nSet1 after IntersectWith(new int[] { 1, 9, 8} : ");
            foreach (var item in set1)
            {
                Console.Write($"{item} ");
            }

            // ExceptWith - Removes all elements in the specified collection from the current object.
            set1.ExceptWith(new int[] { 5, 9 });
            Console.WriteLine("\n\nSet1 after ExceptWith(new int[] { 5, 9} : ");
            foreach (var item in set1)
            {
                Console.Write($"{item} ");
            }

            // IsSubSetOf - Determines if the object is a subset of the specified collection.
            Console.WriteLine($"\n\nIs set1 a subset of set2: {set1.IsSubsetOf(set2)}");

            // IsSuperSetOf - Determines if the object is a superset of the specified collection.
            Console.WriteLine($"\nIs set1 a superset of set2: {set1.IsSupersetOf(set2)}");

            // IsProperSubSetOf - Determines if the object is a proper subset of the specified collection.
            Console.WriteLine($"\nIs set1 a proper subset of set2: {set1.IsProperSubsetOf(set2)}");

            // IsProperSuperSetOf - Determines if the object is a proper superset of the specified collection.
            Console.WriteLine($"\nIs set1 a proper superset of set2: {set1.IsProperSupersetOf(set2)}");


            #region Subset - Superset - Proper Subset - Proper Superset

            /*
            1. Subset
               - A set A is called a subset of set B if every element of A is also an element of B.
               - Symbolically, A ⊆ B

               Let's consider two sets:
               - Set A: {1, 2}
               - Set B: {1, 2, 3, 4, 5}

            2. Superset
               - A set A is called a superset of set B if every element of B is also an element of A.
               - Symbolically, A ⊇ B

               Using the same sets as above:
               - Set A: {1, 2, 3, 4, 5}
               - Set B: {1, 2}

            3. Proper Subset
               - A set A is called a proper subset of set B if A is a subset of B and A is not equal to B.
               - Symbolically, A ⊂ B

               Let's consider two sets:
               - Set A: {1, 2}
               - Set B: {1, 2, 3, 4, 5}

            4. Proper Superset
               - A set A is called a proper superset of set B if A is a superset of B and A is not equal to B.
               - Symbolically, A ⊃ B

               Using the same sets as above:
               - Set A: {1, 2, 3, 4, 5}
               - Set B: {1, 2}

            To summarize:
            - A ⊆ B : Set A is a subset of set B.
            - A ⊇ B : Set A is a superset of set B.
            - A ⊂ B : Set A is a proper subset of set B.
            - A ⊃ B : Set A is a proper superset of set B.

            */

            #endregion

            // A: 1 2 3 4 5
            // B: 1 3 5 7 9 
            // A ꓴ B = 1 2 3 4 5 7 9
            // A ꓵ B = 1 3 5
            // A \ B = 2 4 
            // B \ A = 7 9
            // A ∆ B = 2 4 7 9
            // https://en.wikipedia.org/wiki/Set_(mathematics)
            // https://en.wikipedia.org/wiki/Set_(mathematics)#Basic_operations
        }
    }
}