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
            //Console.WriteLine();
            //Console.ReadKey();

            #endregion

            #region int[][] dataTime

            //int[][] dataTime = new int[24][];
            //for (int j = 0; j < dataTime.Length; j++)
            //{
            //    dataTime[j] = (j >= 9 && j < 21) ? new int[12] : new int[4];
            //}

            //for (int i = 0; i < dataTime.Length; i++)
            //{
            //    for (int j = 0; j < dataTime[i].Length; j++)
            //    {
            //        Console.Write($"{dataTime[i][j],3} ");
            //    }
            //    Console.WriteLine();
            //}

            //// Foreach Loop
            //foreach (var array in dataTime)
            //{
            //    foreach (var e in array)
            //    {
            //        Console.Write($"{e,3} ");
            //    }
            //    Console.WriteLine();
            //}


            ////int[][][] vs = new int[3][][];
            ////vs[0] = new int[3][];

            #endregion

            #region String

            string message = "I AM A C# DEVELOPER";
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write($"{message[i]} ");
            }
            Console.WriteLine();

            foreach (var c in message)
            {
                Console.Write($"{c} ");
            }
            Console.WriteLine();
            Console.ReadKey();

            #endregion

        }
    }
}
