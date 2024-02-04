using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less18NestedClassesBetter
{
    /// <summary>
    /// Enumeration defining sorting criteria for workers.
    /// </summary>
    enum SortedCriterion
    {
        FirstName,
        Salary
    }

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
        /// Nested class implementing IComparer to sort workers by salary.
        /// </summary>
        private class SortBySalary : IComparer<Worker>
        {
            public int Compare(Worker x, Worker y)
            {
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
        /// Nested class implementing IComparer to sort workers by first name.
        /// </summary>
        private class SortByName : IComparer<Worker>
        {
            public int Compare(Worker x, Worker y)
            {
                Worker X = (Worker)x;
                Worker Y = (Worker)y;

                return String.Compare(X.FirstName, Y.FirstName);
            }
        }

        /// <summary>
        /// Factory method to get a comparer based on the specified criterion.
        /// </summary>
        /// <param name="Criterion">Sorting criterion (FirstName or Salary).</param>
        /// <returns>IComparer instance for the specified criterion.</returns>
        public static IComparer<Worker> SortedBy(SortedCriterion Criterion)
        {
            if (Criterion == SortedCriterion.Salary)
                return new SortBySalary();
            else
                return new SortByName();
        }
    }
}
