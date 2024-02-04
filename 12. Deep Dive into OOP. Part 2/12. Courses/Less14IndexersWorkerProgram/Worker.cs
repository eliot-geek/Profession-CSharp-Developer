using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less14IndexersWorkerProgram
{
    /// <summary>
    /// Class describing the worker
    /// </summary>
    internal class Worker
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Position
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Salary
        /// </summary>
        public uint Salary { get; set; }

        /// <summary>
        /// First Name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Output of employee data
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Id: {Id} Position: {Position} Salary: {Salary} Name: {FirstName} ";
        }

        /// <summary>
        /// Worker's creation
        /// </summary>
        /// <param name="Position">Position</param>
        /// <param name="Salary">Salary</param>
        /// <param name="FirstName">name</param>
        public Worker(string Position, uint Salary, string FirstName, int Id)
        {
            this.Position = Position;
            this.Salary = Salary;
            this.FirstName = FirstName;
            this.Id = Id;
        }
    }
}
