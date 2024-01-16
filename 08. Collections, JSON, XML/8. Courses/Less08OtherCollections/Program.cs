namespace Less08OtherCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // System.Collections.Generic.SortedSet
            // System.Collections.Generic.SortedList
            // System.Collections.Generic.SortedDictionary
            // System.Collections.Concurrent
            // ArrayList
            // BitArray

            System.Collections.Stack stack = new System.Collections.Stack();
            stack.Push(1);
            stack.Push("Moscou");
            stack.Push('C');
            stack.Push(1.675);
            stack.Push(2 / 3);
            foreach (var item in stack)
            {
                Console.Write($"\n{item} ");
            }
            Console.WriteLine();

        }
    }
}