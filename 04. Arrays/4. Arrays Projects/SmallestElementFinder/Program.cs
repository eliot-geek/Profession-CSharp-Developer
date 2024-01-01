namespace SmallestElementFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Smallest Element Finder 

            Console.Write("Enter the length of the sequence  : ");
            int quantity = int.Parse(Console.ReadLine());

            int[] array = new int[quantity];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write($"Received sequence : ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            // Initialize the minimum value to the first element of the sequence
            int minValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                }
            }
            Console.Write($"\nSmallest element : {minValue}");
            Console.ReadKey();

            #endregion
        }
    }
}
