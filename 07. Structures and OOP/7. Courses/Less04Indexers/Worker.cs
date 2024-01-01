using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less04Indexers
{
    /// <summary>
    /// Structure
    /// </summary>
    struct Worker
    {
        /// <summary>
        /// Worker's creation
        /// </summary>
        /// <param name="position"></param>
        /// <param name="salary"></param>
        /// <param name="firstName"></param>
        public Worker(string position, uint salary, string firstName)
        {
            Position = position;
            Salary = salary;
            FirstName = firstName;
        }

        /// <summary>
        /// Position
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Salary
        /// </summary>
        public uint Salary { get; set; }

        /// <summary>
        /// FirstName
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Print Worker's data
        /// </summary>
        /// <returns></returns>
        public string Print()
        {
            return $"Position: {Position} Salary: {Salary} First Name: {FirstName}";
        }

    }
}
