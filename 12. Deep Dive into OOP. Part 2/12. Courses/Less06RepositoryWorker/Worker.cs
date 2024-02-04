using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less06RepositoryWorker
{
    /// <summary>
    /// Class describing the employee model.
    /// </summary>
    internal class Worker
    {
        /// <summary>
        /// Gets or sets the worker's First Name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the worker's Last Name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the worker's Age.
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Gets or sets the worker's Salary.
        /// </summary>
        public int Salary { get; set; }

        /// <summary>
        /// Initializes a new instance of the Worker class.
        /// </summary>
        /// <param name="FirstName">The First Name of the worker.</param>
        /// <param name="LastName">The Last Name of the worker.</param>
        /// <param name="Age">The Age of the worker.</param>
        /// <param name="Salary">The Salary of the worker.</param>
        public Worker(string FirstName, string LastName, int Age, int Salary)
        {
            this.FirstName = FirstName; // Save the passed firstname value
            this.LastName = LastName;   // Save the passed lastname value
            this.Age = Age;             // Save the passed age value
            this.Salary = Salary;       // Save the passed salary value
        }

        /// <summary>
        /// Organizes the output of information about the employee.
        /// </summary>
        /// <returns>String representation of information.</returns>
        public override string ToString()
        {
            return $"{FirstName,15} {LastName,15} {Age,10} {Salary.ToString("## ###"),10} руб.";
        }
    }
}
