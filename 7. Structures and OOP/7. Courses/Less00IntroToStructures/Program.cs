namespace Less00IntroToStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Structures and Introduction to OOP
            // Structures: description, usage

            #region MonthlyReport

            // First Option
            MonthlyReport[] report1 = new MonthlyReport[12];
            report1[0] = new MonthlyReport()
            {
                month = "January",
                income = 50000,
                expenses = 40000,
                profit = report1[0].income - report1[0].expenses,
            };
            report1[0].profit = report1[0].income - report1[0].expenses;
            Console.WriteLine("Month: {0} Income: {1} Expenses: {2} Profit: {3}", 
                report1[0].month, 
                report1[0].income, 
                report1[0].expenses, 
                report1[0].profit);


            // Second Option
            MonthlyReport[] report = new MonthlyReport[12];
            report[0] = new MonthlyReport();
            report[0].month = "January";
            report[0].income = 70000;
            report[0].expenses = 40000;
            report[0].profit = report[0].income - report[0].expenses;
            Console.WriteLine("Month: {0} Income: {1} Expenses: {2} Profit: {3}", 
                report[0].month, 
                report[0].income, 
                report[0].expenses, 
                report[0].profit);


            // Third Option
            MonthlyReport january = new MonthlyReport();
            january.month = "January";
            january.income = 70000;
            january.expenses = 40000;
            january.profit = january.income - january.expenses;
            Console.WriteLine("Month: {0} Income: {1} Expenses: {2} Profit: {3}", 
                january.month, 
                january.income, 
                january.expenses, 
                january.profit);

            #endregion

            #region Worker

            Worker worker = new Worker()
            {
                Position = "Founder",
                FirstName = "Anders",
                LastName = "Heljsberg",
                Salary = 500000,
                DateOfBirth = new DateTime(1987, 12, 01)
            };
            Console.WriteLine("Position: {0} FirstName: {1} LastName: {2} Salary: {3} DateOfBirth: {4}", 
                worker.Position, 
                worker.FirstName, 
                worker.LastName, 
                worker.Salary, 
                worker.DateOfBirth);

            #endregion

            Console.ReadKey();
        }
    }
}