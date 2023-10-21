namespace Less07HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region HashSet

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

            HashSet<int> set1 = new HashSet<int>(new int[] { 1, 1, 1, 1, 1, 1, 2, 3, 4, 5, 6, 7, 6, 6, 6, 9, 9, 9 });
            Console.WriteLine("Set1: ");
            foreach (var item in set1)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine($"\n\nElement '3' exists in set1 : {set1.Contains(3)}");
            Console.WriteLine($"Element '20' exists in set1 : {set1.Contains(20)}");

            Console.WriteLine("\nSet 2: ");
            HashSet<int> set2 = new HashSet<int>() { 1, 3, 5, 7, 8, 9, 11, 15 };
            foreach (var item in set2)
            {
                Console.Write($"{item} ");
            }

            set1.UnionWith(set2);
            Console.WriteLine("\n\nSet1 after the union with set2 : ");
            foreach (var item in set1)
            {
                Console.Write($"{item} ");
            }

            set1.ExceptWith(new int[] { 3, 5, 15 });
            Console.WriteLine("\n\nSet1 after ExceptWith(new int[] { 3, 5, 15} : ");
            foreach (var item in set1)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();



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