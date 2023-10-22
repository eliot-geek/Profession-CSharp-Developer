namespace SmallestElementFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Smallest Element Finder 

            // Print the prompt message for the user to input the length of the sequence
            Console.Write("Enter the length of the sequence  : ");
            // Read the user's input for the length of the sequence and store it in the variable "quantity"
            int quantity = int.Parse(Console.ReadLine());

            // Create an array of integers with the size of the sequence length
            int[] array = new int[quantity];
            // Use a for loop to read the user's input for each integer in the sequence and store them in the array
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            // Print the sequence of integers that the user inputted
            Console.Write($"Received sequence : ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            // Initialize the minimum value to the first element of the sequence
            int minValue = array[0];
            // Use a for loop to iterate through each element of the sequence and update the minimum value if a smaller element is found
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                }
            }
            // Print the minimum value
            Console.Write($"\nSmallest element : {minValue}");
            Console.ReadKey();

            #endregion
        }
    }
}