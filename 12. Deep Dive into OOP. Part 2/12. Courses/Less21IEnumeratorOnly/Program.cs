using System.Collections;

namespace Less21IEnumeratorOnly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList numbers = new ArrayList();

            numbers.Add(1); 
            numbers.Add(2);
            numbers.Add(3);

            // Get the enumerator for the collection
            IEnumerator enumerator = numbers.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            Console.WriteLine();


            Console.ReadKey();



            int[] numbers1 = { 1, 2, 3, 4, 5 };

            IEnumerator enumerator1 = numbers1.GetEnumerator();

            while (enumerator1.MoveNext())
            {
                int number = (int)enumerator1.Current;
                Console.WriteLine(number);
            }

            // Release resources occupied by the enumerator
            // enumerator1.Dispose();

            // No need to call Dispose for this particular enumerator, as it doesn't implement IDisposable.
            // If the enumerator was obtained from a type that implements IDisposable, then you would call Dispose.
        }
    }
}
