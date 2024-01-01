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
            Console.ReadLine(); 
            
            #endregion


            #region Old way
            //int head = 0;
            //int tail = numbs.Length - 1;
            //bool flag = true;
            //while (head < tail)
            //{
            //    if (flag)
            //    {
            //        if (numbs[head] == 1) flag = false;
            //        else head++;
            //    }
            //    else
            //    {
            //        if (numbs[tail] == 0) flag = true;
            //        else tail--;
            //    }

            //    if (numbs[head] == 1 && numbs[tail] == 0)
            //    {
            //        int temp = numbs[head];
            //        numbs[head] = numbs[tail];
            //        numbs[tail] = temp;

            //        head++;
            //        tail--;
            //    }
            //}
            #endregion
        }
    }
}
