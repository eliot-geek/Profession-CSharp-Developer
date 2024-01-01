namespace ArraysProjects
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

            #region Task 2

            // The client needs an application that builds the first N rows of Pascal's triangle. N < 25.
            // When N = 9, the triangle looks like this:
            // 1
            // 1       1
            // 1       2       1
            // 1       3       3       1
            // 1       4       6       4       1
            // 1       5      10      10       5       1
            // 1       6      15      20      15       6       1
            // 1       7      21      35      35       21      7       1

            #endregion

            #region Task 2 Difficult Level

            // The client needs an application that builds the first N rows of Pascal's triangle. N < 25.
            // When N = 9, the triangle looks like this:

            //                                 1
            //                             1       1
            //                         1       2       1
            //                     1       3       3       1
            //                 1       4       6       4       1
            //             1       5      10      10       5       1
            //         1       6      15      20      15       6       1
            //     1       7      21      35      35       21      7       1

            // Pascal's triangle is a triangular array of numbers in which the first and last numbers of each row are 1,
            // and each of the remaining numbers is the sum of the two numbers directly above it. 

            #endregion
        }
    }
}