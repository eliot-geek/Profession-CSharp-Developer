namespace FinancialReportCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Solution 1

            Console.WriteLine("FINANCIAL ACCOUNTING APPLICATION\n");
            Random randomize = new Random();
            int[,] array2D = new int[12, 4];
            int[] benefice = new int[12];

            int income = 0;        // keep track of total income
            string months = "";    // months with worst profit
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
                benefice[i] = array2D[i, 3];                        // Store the financial data for each month 
                Console.WriteLine($"{array2D[i, 0],5} {array2D[i, 1],18} {array2D[i, 2],14} {array2D[i, 3],11}");
            }
            // "Distinct" method to remove duplicate profit/loss values 
            benefice = benefice.Distinct().ToArray();
            Array.Sort(benefice); 

            // Loop through the worst profit values
            for (int j = 0; j < 3; j++)  
            {
                if (j >= benefice.Length)
                {
                    break;
                }
                for (int i = 0; i < 12; i++)
                {
                    // Months with positive profit
                    if (array2D[i, 3] > 0 && j == 0)
                    {
                        income++;
                    }
                    // Worst profit in months
                    if (array2D[i, 3] == benefice[j])
                    {
                        if (String.IsNullOrWhiteSpace(months))
                        {
                            months = (i + 1).ToString();
                        }
                        else
                        {
                            months = months + ", " + (i + 1).ToString();
                        }
                    }
                }
            }
            
            Console.WriteLine($"\nWorst profit in months: {months}");
            Console.WriteLine($"Months with positive profit : {income}\n");
            Console.ReadKey();
            #endregion


            #region Solution 2

            int[] incom = new int[] { 100000, 120000, 80000, 70000, 100000, 200000, 130000, 150000, 190000, 110000, 150000, 100000 };
            int[] expens = new int[] { 80000, 90000, 70000, 70000, 80000, 120000, 140000, 65000, 90000, 70000, 120000, 80000 };
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
            
            Console.WriteLine("Month\tIncome, $\tExpenses, $\tProfit, $");
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}", i + 1, incom[i], expens[i], profits[i]);
            }
            
            Console.WriteLine("\nWorst profit in months: {0}, {1}, {2}", worstProfits[0], worstProfits[1], worstProfits[2]);
            Console.WriteLine("Months with positive profit: {0}", positiveProfitMonths);

            #endregion
        }
    }
}
