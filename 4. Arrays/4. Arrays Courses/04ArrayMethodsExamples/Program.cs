namespace _04ArrayMethodsExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new int[] { 1, 5, 2, 5, 4, 6, 5, 7, 6, 8, 6, 9, 5, 1 };
            Console.WriteLine("Original array: ");
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write($"{data[i]} ");
            }
            Console.WriteLine();

            // Output the length of the array
            Console.WriteLine($"data.Length = {data.Length}");
            // Find the index of the first occurrence of 5 in the array
            int result = Array.IndexOf(data, 5); 
            Console.WriteLine($"Array.IndexOf(data, 5) = {result}");

            // Find the index of the last occurrence of 5 in the array
            result = Array.LastIndexOf(data, 5);
            Console.WriteLine($"Array.LastIndexOf(data, 5) = {result}");

            // Get the rank (number of dimensions) of the array
            int rank = data.Rank; 
            Console.WriteLine($"data.Rank = {rank}");

            // Sort the elements in the array
            Array.Sort(data);
            Console.WriteLine("\nArray after applying Array.Sort(data): ");
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write($"{data[i]} ");
            }
            Console.WriteLine();

            // Reverse the order of the elements in the array
            Array.Reverse(data);
            Console.WriteLine("Array after applying Array.Reverse(data): ");
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write($"{data[i]} ");
            }
            Console.WriteLine();

            // Clear starting at a specified index (7). (3) - the number of elements to clear (replace with 0)
            Array.Clear(data, 7, 3);
            Console.WriteLine("Array after applying Array.Clear(data, 7, 3): ");
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write($"{data[i]} ");
            }
            Console.WriteLine();

            // Copy a range of elements from one array to another
            int[] copyData = new int[20];
            Array.ConstrainedCopy(data, 2, copyData, 10, 5); // Copies from index (2) of the source, and pastes them at index (10) of the destination. (5) - number of elements to copy

            //Array.Copy()
            Console.WriteLine("Array copyData: ");
            for (int i = 0; i < copyData.Length; i++)
            {
                Console.Write($"{copyData[i]} ");
            }
            Console.WriteLine();

            Array.ConstrainedCopy(data, 4, copyData, 10, 5);
            Console.WriteLine("Array copyData after applying Array.ConstrainedCopy(data, 4, copyData, 10, 5): ");
            for (int i = 0; i < copyData.Length; i++)
            {
                Console.Write($"{copyData[i]} ");
            }
            Console.WriteLine("\n");
        }
    }
}
