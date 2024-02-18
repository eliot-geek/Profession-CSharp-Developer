using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less06LimitationsGenericsTypes
{
    /// <summary>
    /// Represents a worker with basic information such as position, salary, first name, last name, and date of birth.
    /// </summary>
    public struct Worker
    {
        /// <summary>
        /// Default constructor for the Worker struct.
        /// </summary>
        public Worker() { }


        /// <summary>
        /// The position of the worker.
        /// </summary>
        public string Position;

        /// <summary>
        /// The salary of the worker.
        /// </summary>
        public uint Salary;

        /// <summary>
        /// The first name of the worker.
        /// </summary>
        public string FirstName;

        /// <summary>
        /// The last name of the worker.
        /// </summary>
        public string LastName;

        /// <summary>
        /// The date of birth of the worker.
        /// </summary>
        public DateTime DateOfBirth;
    }
}
