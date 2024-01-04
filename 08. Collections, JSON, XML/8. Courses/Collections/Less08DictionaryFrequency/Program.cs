﻿namespace Less08DictionaryFrequency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Frequency Dictionary

            // A Frequency Dictionary in the context of C# typically refers to a data structure used for counting the frequency of occurrence of elements
            // (usually words or items in a dataset) in a collection. It allows you to determine how often each element appears in the collection.

            #endregion

            List<int> list = new List<int>();
            Random r = new Random();
            for (int i = 0; i < 100; i++)
            {
                list.Add(r.Next(20));
            }
            foreach (int i in list) 
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\n");


            var dictionary = new Dictionary<int, int>();
            foreach (var e in list)
            {
                if (!dictionary.ContainsKey(e))
                {
                    dictionary.Add(e, 0);
                }
                dictionary[e]++;
            }

            foreach (KeyValuePair<int, int> e in dictionary)
            {
                Console.WriteLine($"{e.Key,3} meets {e.Value,3} times.");
            }
            Console.WriteLine();
        }
    }
}