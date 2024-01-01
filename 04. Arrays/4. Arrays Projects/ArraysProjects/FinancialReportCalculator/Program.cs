namespace FinancialReportCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1 

            // Task 1.
            // The customer asks you to write an application for accounting finances and demonstrate its operation.
            // The essence of the task is as follows:
            // The management of the company keeps track of income and expenses over 12 months.
            // Two arrays are obtained for the year - expenses and income.
            // Determine profits by month
            // Number of months with positive profit.
            // Add the ability to output the three worst indicators by month, with the worst profit,
            // if there are several months, in some of which the worst profit coincided - display all of them.
            // Organize a user-friendly interface like this 

            // Example
            //
            // Month            Income, $         Expenses, $             Profit, $ 
            //     1              100,000              80,000                20,000
            //     2              120,000              90,000                30,000
            //     3               80,000              70,000                10,000
            //     4               70,000              70,000                     0
            //     5              100,000              80,000                20,000
            //     6              200,000             120,000                80,000
            //     7              130,000             140,000               -10,000
            //     8              150,000              65,000                85,000
            //     9              190,000              90,000               100,000
            //    10              110,000              70,000                40,000
            //    11              150,000             120,000                30,000
            //    12              100,000              80,000                20,000
            // 
            // Worst profit in months: 7, 4, 1, 5, 12
            // Months with positive profit: 10

            #endregion


            #region Solution

            // Display title of the program
            Console.WriteLine("FINANCIAL ACCOUNTING APPLICATION\n");
            // Create a new instance of the Random class
            Random randomize = new Random();
            // Declare a 2D array with 12 rows and 4 columns to store financial data for each month
            int[,] array2D = new int[12, 4];
            // Declare an array to store profit/loss of each month
            int[] benefice = new int[12];

            // Declare a variable to keep track of total income
            int income = 0;
            // Declare a variable to store a string representation of months with worst profit
            string months = "";
            // Declare an array containing titles for each column and display them
            string[] title = { "Month", " Income, $", "Expenses, $", "Profit, $", };
            for (int i = 0; i < title.Length; i++)
            {
                Console.Write($"{title[i],-13} ");
            }
            Console.WriteLine();

            // Loop through the 12 months and generate random values for income and expenses
            for (int i = 0; i < 12; i++)
            {
                array2D[i, 0] = i + 1;
                array2D[i, 1] = randomize.Next(1, 7) * 10000;
                array2D[i, 2] = randomize.Next(1, 3) * 10000;
                array2D[i, 3] = array2D[i, 1] - array2D[i, 2];      // Calculate the profit by subtracting expenses from income
                benefice[i] = array2D[i, 3];                        // Store the financial data for each month in the 2D array and display it on the console
                Console.WriteLine($"{array2D[i, 0],5} {array2D[i, 1],18} {array2D[i, 2],14} {array2D[i, 3],11}");
            }
            // "Distinct" method to Remove duplicate profit/loss values 
            benefice = benefice.Distinct().ToArray();
            // "Sort" method of the "Array" class to sort the "benefice" array in ascending order.
            Array.Sort(benefice);

            // Loop through the 3 worst profit values
            // If there are fewer than 3 distinct profit values, exit the loop
            for (int j = 0; j < 3; j++)  // iterating over the variable "j" from 0 to 2
            {
                if (j >= benefice.Length)
                {
                    break;
                }
                // This nested loop is iterating over the variable "i" from 0 to 11.
                for (int i = 0; i < 12; i++)
                {
                    // Checks if the value in the fourth column of a two-dimensional array "array2D" at the current index is greater than zero 
                    // and if "j" is equal to 0. If this is true, the variable "income" is incremented.
                    if (array2D[i, 3] > 0 && j == 0)
                    {
                        income++;
                    }
                    // Checks if the value in the fourth column of the "array2D" array at the current index is equal to the value of the "benefice" array at index "j". 
                    // If this is true, a string variable "months" is updated to include the current month (i+1) in a comma-separated list.
                    if (array2D[i, 3] == benefice[j])
                    {
                        // This conditional statement checks if the "months" variable is null, empty or contains only whitespace.
                        if (String.IsNullOrWhiteSpace(months))
                        {
                            // If true, the "months" variable is assigned a string representation of the current month (i+1).
                            months = (i + 1).ToString();
                        }
                        else
                        {
                            // If false, the "months" variable is updated to include the current month (i+1) in a comma-separated list.
                            months = months + ", " + (i + 1).ToString();
                        }
                    }
                }
            }
            // Display the worst months and the number of months with positive profit
            Console.WriteLine($"\nWorst profit in months: {months}");
            Console.WriteLine($"Months with positive profit : {income}\n");
            Console.ReadKey();
            #endregion


            #region Solution 2

            // Declare and initialize arrays for income and expenses
            int[] incom = new int[] { 100000, 120000, 80000, 70000, 100000, 200000, 130000, 150000, 190000, 110000, 150000, 100000 };
            int[] expens = new int[] { 80000, 90000, 70000, 70000, 80000, 120000, 140000, 65000, 90000, 70000, 120000, 80000 };
            // Declare variables for profits, worst profits, and months with positive profits
            int[] profits = new int[12];
            int[] worstProfits = new int[3];
            int positiveProfitMonths = 0;
            // Calculate profits and count positive profit months
            for (int i = 0; i < 12; i++)
            {
                profits[i] = incom[i] - expens[i];
                if (profits[i] > 0)
                {
                    positiveProfitMonths++;
                }
            }
            // Find worst profits
            for (int i = 0; i < 3; i++)
            {
                int worstProfit = int.MaxValue;
                for (int j = 0; j < 12; j++)
                {
                    if (profits[j] < worstProfit)
                    {
                        bool isDuplicate = false;
                        for (int k = 0; k < i; k++)
                        {
                            if (worstProfits[k] == j + 1)
                            {
                                isDuplicate = true;
                                break;
                            }
                        }
                        if (!isDuplicate)
                        {
                            worstProfits[i] = j + 1;
                            worstProfit = profits[j];
                        }
                    }
                }
            }
            // Print table of profits by month
            Console.WriteLine("Month\tIncome, $\tExpenses, $\tProfit, $");
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}", i + 1, incom[i], expens[i], profits[i]);
            }
            // Print worst profit months and months with positive profit
            Console.WriteLine("\nWorst profit in months: {0}, {1}, {2}", worstProfits[0], worstProfits[1], worstProfits[2]);
            Console.WriteLine("Months with positive profit: {0}", positiveProfitMonths);

            #endregion
        }
    }
}