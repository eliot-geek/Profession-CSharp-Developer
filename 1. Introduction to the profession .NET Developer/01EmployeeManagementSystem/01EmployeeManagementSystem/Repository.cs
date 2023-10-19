using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01EmployeeManagementSystem
{
    /// <summary>
    /// Organization of data storage and generation
    /// </summary>
    internal class Repository
    {
        /// <summary>
        /// Database of names
        /// </summary>
        static readonly string[] firstNames;

        /// <summary>
        /// Database of surnames
        /// </summary>
        static readonly string[] lastNames;

        /// <summary>
        /// Pseudorandom Number Generator
        /// </summary>
        static Random randomize;

        /// <summary>
        /// A static constructor that "stores" data about firstname and lastname databases
        /// </summary>
        static Repository()
        {
            // Placing a random number generator in memory
            randomize = new Random();

            // Placing names in the firstnames database
            firstNames = new string[] {
                "Sarah",
                "Jhon",
                "Emily",
                "David",
                "Maria",
                "James",
                "Samantha",
            };

            // Placing names in the lastnames database
            lastNames = new string[]
            {
                "Johnson",
                "Smith",
                "Williams",
                "Brown",
                "Jones",
                "Garcia",
                "Miller",
                "Davis",
                "Martinez",
                "Hernandez",
                "Rodriguez",
                "Wilson",
                "Anderson",
                "Taylor",
                "Thomas",
                "Jackson",
                "White",
                "Martin",
                "Harris",
                "Thompson",
                "Garcia"
            };
        }

        /// <summary>
        /// An employee database that stores the first name, last name, age, and salaries of each employee
        /// </summary>
        public List<Employee> Workers { get; set; }

        /// <summary>
        /// Constructor that populates the Workers database
        /// </summary>
        /// <param name="Count">Number of employees to be created</param>
        public Repository(int Count)
        {
            // Allocation of memory for storing the Workers database
            this.Workers = new List<Employee>();

            // Filling in the Workers database. Executed Count times
            for (int i = 0; i < Count; i++)    
            {
                // Adding a new employee to the Workers database
                this.Workers.Add(
                    new Employee(
                        // choosing a random name from the database of names
                        firstNames[Repository.randomize.Next(Repository.firstNames.Length)],

                        // choosing a random name from the database of lastnames
                        lastNames[Repository.randomize.Next(Repository.lastNames.Length)],

                        // We generate a random age in the range of 19 years - 60 years
                        randomize.Next(19, 60),

                        // We generate a random salary in the range of 10000 $ - 80,000 $
                        randomize.Next(10000, 80000)
                        ));
            }
        }

        /// <summary>
        /// Method of output of the Workers database to the console
        /// </summary>
        /// <param name="Text">Auxiliary text that will be printed before the output of the database</param>
        public void Print(string Text)
        {
            // Printing auxiliary text to the console
            Console.WriteLine(Text);

            // Changing the font color for printing in the console to DarkBlue
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            // Output the headers of the database columns
            Console.WriteLine($"{"Name",15} {"Lastname",15} {"Age",10} {"Salary",15}");

            // Changing the font color for printing in the console to Gray
            Console.ForegroundColor = ConsoleColor.Gray;

            // We print all employees to the console
            foreach (var worker in this.Workers) 
            {                                    
                Console.WriteLine(worker);       
            }

            // Summary report. How many employees are printed out
            Console.WriteLine($"Total: {this.Workers.Count}\n");    
        }

        /// <summary>
        /// A method that dismisses employees with a salary greater than the specified one
        /// </summary>
        /// <param name="MaxSalary">The salary level of the employee who needs to be fired</param>
        public void DeleteEmployeeBySalary(int MaxSalary)
        {
            // Deleting employees whose salary is greater than the specified Max Salary
            this.Workers.RemoveAll(e => e.Salary > MaxSalary);
        }

        /// <summary>
        /// A method that dismisses employees with a given name
        /// </summary>
        /// <param name="CurrentName">Name of the employees to be fired</param>
        public void DeleteEmployeeByName(string CurrentName)
        {
            // Deleting employees whose name Matches the selected CurrentName
            this.Workers.RemoveAll(e => e.FirstName == CurrentName);
        }
    }
}
