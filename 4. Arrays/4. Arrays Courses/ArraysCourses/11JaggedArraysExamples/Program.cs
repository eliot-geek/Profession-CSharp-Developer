namespace _11JaggedArraysExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program that simulates the acquisition of data from a weather station. Collect and store information about air temperature
            // During the period from 9 am to 9 pm every 5 minutes
            // During the period from 9 pm to 9 am every 15 minutes

            #region  int[,] dataTime 

            //// Create an instance of Random class
            //Random r = new Random();
            //// Create a 2D integer array to store temperature data for each hour of the day
            //// 24 represents the number of hours in a day, and 12 represents the number of 5-minute intervals within each hour
            //int[,] dataTime = new int[24, 12];

            //// Loop through each hour of the day
            //for (int i = 0; i < dataTime.GetLength(0); i++)
            //{
            //    // Print the hour
            //    Console.Write($"{i,3}h. ");
            //    // Loop through each 5-minute or 15-minute interval depending on the time of day
            //    for (int j = 0; j < dataTime.GetLength(1); j++)
            //    {
            //        // Set the temperature for the current interval based on the time of day
            //        if (i >= 9 && i < 21)
            //            dataTime[i, j] = r.Next(20); // if between 9am and 9pm, generate a random temperature between 0 and 20
            //        else
            //            dataTime[i, j] = (j < 4) ? r.Next(20) : 0; // if between 9pm and 9am, generate a random temperature between 0 and 20 only for the first 4 intervals (1 hour), otherwise set the temperature to 0
            //        // Print the temperature for the current interval
            //        Console.Write($"{dataTime[i, j],3} ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.ReadKey();
            //Console.Clear();
            //// Iterate through every hour of the day
            //for (int i = 0; i < dataTime.GetLength(0); i++)
            //{
            //    // Set the console text color to white and write the hour number
            //    Console.ForegroundColor = ConsoleColor.White;
            //    Console.Write($"{i,3}h. ");
            //    for (int j = 0; j < dataTime.GetLength(1); j++)
            //    {
            //        // Set the console text color to white if it is daytime, or red if it is nighttime and past the 4th 15 minute interval
            //        if (i >= 9 && i < 21) Console.ForegroundColor = ConsoleColor.White;
            //        else Console.ForegroundColor = (j < 4) ? ConsoleColor.White : ConsoleColor.Red;
            //        // Write the temperature measurement for this interval
            //        Console.Write($"{dataTime[i, j],3} ");
            //    }
            //    // Move to the next line
            //    Console.WriteLine();
            //}
            //// Set the console text color back to white after we are done with the loop
            //Console.ForegroundColor = ConsoleColor.White;

            #endregion

            #region int[][] dataTime  - Why store all of this in vain? That's why we will use an array of arrays.

            // Initialize a random number generator
            Random r = new Random();
            // Declare a jagged array to store dataTime information for 24 hours
            int[][] dataTime = new int[24][];
            // Assign the number of elements for each array based on time of day
            for (int j = 0; j < dataTime.Length; j++)
            {
                // initializes an array of arrays where each nested array has 12 elements if the index is between 9 and 20 (inclusive) and 4 elements otherwise.
                dataTime[j] = (j >= 9 && j < 21) ? new int[12] : new int[4];
            }

            // Iterate over dataTime array and populate it with random temperature values
            for (int i = 0; i < dataTime.Length; i++)
            {
                // Write the label for the current row
                Console.Write($"{i} h. ");
                // Iterate over the columns of the current row
                for (int j = 0; j < dataTime[i].Length; j++)
                {
                    // Assign a random integer between 0 and 19 to the current element of the 2D array
                    dataTime[i][j] = r.Next(20);
                    // Write the value of the current element with a width of 3 characters
                    Console.Write($"{dataTime[i][j],3} ");
                }
                // Move to the next line to prepare for the next row of output
                Console.WriteLine();
            }

            #endregion

        }
    }
}