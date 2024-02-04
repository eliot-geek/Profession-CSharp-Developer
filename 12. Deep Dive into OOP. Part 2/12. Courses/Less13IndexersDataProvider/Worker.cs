using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less13IndexersDataProvider
{
    /// <summary>
    /// Represents a worker in an organization with information such as position, salary, and first name.
    /// </summary>
    internal class Worker
    {
        /// <summary>
        /// Position of the worker.
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Salary of the worker.
        /// </summary>
        public uint Salary { get; set; }

        /// <summary>
        /// First name of the worker.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets the formatted string representation of employee data.
        /// </summary>
        /// <returns>Formatted string with position, salary, and name.</returns>
        public override string ToString()
        {
            return $"Position: {Position} Salary: {Salary} Name: {FirstName}";
        }

        /// <summary>
        /// Creates a new instance of the Worker class.
        /// </summary>
        /// <param name="Position">Position of the worker.</param>
        /// <param name="Salary">Salary of the worker.</param>
        /// <param name="FirstName">First name of the worker.</param>
        public Worker(string Position, uint Salary, string FirstName)
        {
            this.Position = Position;
            this.Salary = Salary;
            this.FirstName = FirstName;
        }
    }
}
