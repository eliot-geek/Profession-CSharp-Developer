namespace _12ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 7. The foreach loop

            #region Task 1

            //Console.WriteLine("Create an array of N random numbers from -5 to 5.");
            //Console.Write("Enter n: ");                 
            //int n = int.Parse(Console.ReadLine());      
            //Random random = new Random();               
            //int[] numbs = new int[n];                   
            //for (int i = 0; i < numbs.Length; i++)      
            //{                                           
            //    numbs[i] = random.Next(-5, 6);          
            //}                                            

            //for (int i = 0; i < numbs.Length; i++)      
            //{                                           
            //    Console.Write($"{numbs[i]} ");           
            //}                                           
            //Console.WriteLine();

            //// Foreach loop

            //foreach (var e in numbs)
            //{
            //    Console.Write($"{e} ");
            //}
            //Console.ReadKey();

            #endregion

            #region int[][] dataTime

            //// Create a 2D integer array called 'dataTime' with 24 rows and no columns initially.
            //int[][] dataTime = new int[24][];
            //// Loop through each row in the 'dataTime' array.
            //for (int j = 0; j < dataTime.Length; j++)
            //{
            //    // If the current row (j) is between 9 (inclusive) and 21 (exclusive),
            //    // create a new array with 12 columns and assign it to the current row (j) of 'dataTime'.
            //    // Otherwise, create a new array with 4 columns and assign it to the current row (j) of 'dataTime'.
            //    dataTime[j] = (j >= 9 && j < 21) ? new int[12] : new int[4];
            //}
            //// Loop through each row (i) in the 'dataTime' array.
            //for (int i = 0; i < dataTime.Length; i++)
            //{
            //    // Loop through each column (j) in the current row (i) of the 'dataTime' array.
            //    for (int j = 0; j < dataTime[i].Length; j++)
            //    {
            //        Console.Write($"{dataTime[i][j],3} ");
            //    }
            //    Console.WriteLine();
            //}

            //// Foreach Loop
            //// Loop through each array in the 'dataTime' array 
            //foreach (var array in dataTime)
            //{
            //    // Loop through each element (e) in the current array 
            //    foreach (var e in array)
            //    {
            //        // Write the current element (e) to the console with a minimum width of 3 characters to align the output
            //        Console.Write($"{e,3} ");
            //    }
            //    Console.WriteLine();
            //}


            ////int[][][] vs = new int[3][][];
            ////vs[0] = new int[3][];

            #endregion

            #region String

            //string message = "I AM A C# DEVELOPER";
            //for (int i = 0; i < message.Length; i++)
            //{
            //    Console.Write($"{message[i]} ");
            //}
            //Console.WriteLine();

            //foreach (var c in message)
            //{
            //    Console.Write($"{c} ");
            //}
            //Console.WriteLine(); Console.ReadKey();

            #endregion

        }
    }
}