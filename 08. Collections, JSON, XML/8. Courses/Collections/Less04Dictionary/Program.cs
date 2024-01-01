namespace Less04Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dictionary<TKey, TValue>

            // key, value
            // Add - Adds the specified key and value to the dictionary
            // Count - Returns the number of key-value pairs contained in the dictionary
            // Clear - Removes all keys and values from the dictionary
            // [] - Gets or sets the value associated with the specified key
            // ContainsKey - Determines whether the dictionary contains the specified key
            // Remove - Removes the value with the specified key from the dictionary
            // Keys - Returns a collection containing the keys in the dictionary
            // Values - Returns a collection containing the values in the dictionary
            // KeyValuePair<string, string>

            #endregion
            
            Dictionary<string, string> pairs = new Dictionary<string, string>();
            pairs.Add("Professor", "Teacher");
            pairs.Add("Educators", "Univers");
            pairs.Add("Computers", "AppleHP");
            pairs.Add("Vehicules", "Buggati");
            Console.WriteLine("Pairs");
            foreach (KeyValuePair<string, string> e in pairs)
            {
                Console.WriteLine($"{e} ");
            }
            Console.WriteLine();
            Console.WriteLine($"pairs[\"Professor\"] = {pairs["Professor"]}"); 
            Console.WriteLine($"pairs[\"Vehicules\"] = {pairs["Vehicules"]}");

            Console.WriteLine("\nPairs.Keys");
            foreach (var e in pairs.Keys)
            {
                Console.Write($"{e} ");
            }

            Console.WriteLine("\nPairs.Values");
            foreach (var e in pairs.Values)
            {
                Console.Write($"{e} ");
            }

            Console.WriteLine("\n\nDelete \"Professor\"");
            pairs.Remove("Professor");

            Console.WriteLine("\nPairs");
            foreach (KeyValuePair<string, string> e in pairs)
            {
                Console.WriteLine($"{e} ");
            }

            Console.WriteLine($"\nElements in Dictionnary: {pairs.Count}");
            pairs.Clear();
            Console.WriteLine("Pairs.Clear(); done");
            Console.WriteLine($"Elements in Dictionnary: {pairs.Count}");
        }
    }
}