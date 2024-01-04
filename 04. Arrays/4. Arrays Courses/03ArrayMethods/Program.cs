namespace _03ArrayMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4.2 Basic methods of working with one-dimensional arrays 

            // Declare and initialize variables
            Console.WriteLine("An array with n elements which contains only zeros and ones, with zeros at the beginning and ones at the end.");
            Console.Write("\nNumber of elements: ");
            int n = int.Parse(Console.ReadLine());
            Random random = new Random();
            int[] numbs = new int[n];

            // Fill the array with random 0s and 1s and display it
            Console.Write("\nOriginal array: ");
            for (int i = 0; i < numbs.Length; i++)
            {
                numbs[i] = random.Next(0, 2);
                Console.Write($"{numbs[i]} ");
            }

            #region TODO

            // Sort the array and display it
            Array.Sort(numbs);
            Console.Write("\nSorted   array: ");
            for (int i = 0; i < numbs.Length; i++)
            {
                Console.Write($"{numbs[i]} ");
            }
            // Wait for user input before closing the console window
            Console.ReadLine(); 
            
            #endregion


            #region Old way
            //// Initialize the head and tail pointers to the beginning and end of the array, respectively
            //int head = 0;
            //int tail = numbs.Length - 1;
            //// Initialize a flag variable to keep track of which element (0 or 1) should be swapped next
            //bool flag = true;
            //// Swap the 0's and 1's until the zeros are all at the beginning and the ones are all at the end
            //while (head < tail)
            //{
            //    if (flag)
            //    {
            //        // If the current element at the head pointer is 1, set the flag to false, otherwise increment the head pointer
            //        if (numbs[head] == 1) flag = false;
            //        else head++;
            //    }
            //    else
            //    {
            //        // If the current element at the tail pointer is 0, set the flag to true, otherwise decrement the tail pointer
            //        if (numbs[tail] == 0) flag = true;
            //        else tail--;
            //    }

            //    // If both the current element at the head pointer is 1 and the current element at the tail pointer is 0, swap the elements
            //    if (numbs[head] == 1 && numbs[tail] == 0)
            //    {
            //        int temp = numbs[head];
            //        numbs[head] = numbs[tail];
            //        numbs[tail] = temp;

            //        // Increment the head pointer and decrement the tail pointer
            //        head++;
            //        tail--;
            //    }
            //}
            #endregion
        }
    }
}