namespace _01EmployeeManagementSystem
{
    /// <summary>
    /// The main component unit of the application is the class
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The code that is executed first
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Creating a database of 30 employees
            Repository repository = new Repository(30);

            // Printing to the console of all employees
            repository.Print("Database before conversion");

            // Dismissal of all employees with the name 
            repository.DeleteEmployeeByName("Jhon");

            // Printing to the console of employees who were not fired
            repository.Print("Database after the first dismissal");

            // Dismissal of all employees with the name 
            repository.DeleteEmployeeByName("Sarah");

            // Printing to the console of employees who were not fired
            repository.Print("Database after the second dismissal");
            Console.ReadKey();

            #region Homework

            // Difficulty level: Simple
            // Task 1. Redo the program so that before the first wave of layoffs in the department there were no more than 20 employees

            Console.WriteLine("Task 1. Redo the program so that before the first wave of layoffs in the department there were no more than 20 employees");
            Console.WriteLine("Creating a database of 20 employees is enough to complete this task, because after a few deletions there will be less than 20");

            // Difficulty level: Medium difficulty
            // * Task 2. Create a department of 40 employees and implement several layoffs, according to the results of which no more than 30 employees should remain in the department

            Console.WriteLine("\n\nTask 2. Create a department of 40 employees and implement several layoffs, according to the results of which no more than 30 employees should remain in the department");
            Console.WriteLine("Creating a database of 40 employees is enough to complete this task and force some to quit, to be sure that the rest will be less than 30, choosing names or salary");


            // Difficulty level: Difficult
            // ** Task 3. Create a department of 50 employees and implement the dismissal of employees whose salary exceeds 30,000 $

            repository.Print("\n\nTask 3. Create a department of 50 employees and implement the dismissal of employees whose salary exceeds 30,000 $");
            // Dismissal of all employees with a salary greater than the specified one
            repository.DeleteEmployeeBySalary(30000);

            // Printing to the console of employees who were not fired
            repository.Print("Database after conversion");

            #endregion

        }
    }
}