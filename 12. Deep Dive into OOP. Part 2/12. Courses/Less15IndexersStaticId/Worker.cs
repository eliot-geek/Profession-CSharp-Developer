using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less15IndexersStaticId
{
    /// <summary>
    /// Class describing the worker
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
        /// Name of the worker.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets the formatted string representation of employee data.
        /// </summary>
        /// <returns>Formatted string with ID, position, salary, and name.</returns>
        public override string ToString()
        {
            return $"Id: {Id} Position: {Position} Salary: {Salary} Name: {FirstName} ";
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
    }
}
