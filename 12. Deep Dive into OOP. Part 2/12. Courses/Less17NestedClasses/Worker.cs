using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less17NestedClasses
{
    /// <summary>
    /// Class describing the worker.
    /// </summary>
    internal class Worker
    {
        /// <summary>
        /// Static Field staticId to keep track of the next available ID.
        /// </summary>
        private static int staticId;

        /// <summary>
        /// Static Constructor initializing the staticId to 0.
        /// </summary>
        static Worker()
        {
            staticId = 0;
        }

        /// <summary>
        /// A static method that returns the next available ID and increments staticId.
        /// </summary>
        /// <returns>Next available ID</returns>
        private static int NextId()
        {
            staticId++;
            return staticId;
        }

        /// <summary>
        /// Id Number assigned to each worker instance.
        /// </summary>
        public int Id { get; set; }

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
        /// <returns>Formatted string with ID, position, salary, and name.</returns>
        public override string ToString()
        {
            return $"Id: {Id,4} Position: {Position,15} Salary: {Salary,5} Name: {FirstName,15} ";
        }

        /// <summary>
        /// Constructor for creating a new instance of the Worker class.
        /// </summary>
        /// <param name="Position">Position of the worker.</param>
        /// <param name="Salary">Salary of the worker.</param>
        /// <param name="FirstName">Name of the worker.</param>
        public Worker(string Position, uint Salary, string FirstName)
        {
            // Assigning a unique ID to each worker instance using the NextId() method.
            this.Id = Worker.NextId();
            this.Position = Position;
            this.Salary = Salary;
            this.FirstName = FirstName;
        }

        /// <summary>
        /// Custom comparer class for sorting workers by salary.
        /// Implements the IComparer interface for Worker instances.
        /// </summary>
        public class SortBySalary : IComparer<Worker>
        {
            /// <summary>
            /// Compares two workers based on their salary.
            /// </summary>
            /// <param name="x">The first worker to compare.</param>
            /// <param name="y">The second worker to compare.</param>
            /// <returns>
            /// Returns 0 if salaries are equal, 1 if the salary of the first worker is greater,
            /// and -1 if the salary of the second worker is greater.
            /// </returns>
            public int Compare(Worker x, Worker y)
            {
                // Casting to Worker type for comparison.
                Worker X = (Worker)x;
                Worker Y = (Worker)y;

                if (X.Salary == Y.Salary)
                    return 0;
                else if (X.Salary > Y.Salary)
                    return 1;
                else
                    return -1;
            }
        }

        /// <summary>
        /// Custom comparer class for sorting workers by first name.
        /// Implements the IComparer interface for Worker instances.
        /// </summary>
        public class SortByName : IComparer<Worker>
        {
            /// <summary>
            /// Compares two workers based on their first name.
            /// </summary>
            /// <param name="x">The first worker to compare.</param>
            /// <param name="y">The second worker to compare.</param>
            /// <returns>
            /// Returns a value less than 0 if the first worker's name is lexicographically less,
            /// 0 if names are equal, and a value greater than 0 if the first worker's name is lexicographically greater.
            /// </returns>
            public int Compare(Worker x, Worker y)
            {
                // Casting to Worker type for comparison.
                Worker X = (Worker)x;
                Worker Y = (Worker)y;

                return String.Compare(X.FirstName, Y.FirstName);
            }
        }
    }
}
