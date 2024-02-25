using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less01MethodAsParameter
{
    /// <summary>
    /// Represents a worker with basic information such as first name, last name, age, and salary.
    /// </summary>
    public class Worker
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Worker"/> class with the specified parameters.
        /// </summary>
        /// <param name="firstName">The first name of the worker.</param>
        /// <param name="lastName">The last name of the worker.</param>
        /// <param name="age">The age of the worker.</param>
        /// <param name="salary">The salary of the worker.</param>
        public Worker(string firstName, string lastName, int age, int salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        /// <summary>
        /// Gets or sets the first name of the worker.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name of the worker.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the age of the worker.
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Gets or sets the salary of the worker.
        /// </summary>
        public int Salary { get; set; }

        /// <summary>
        /// Returns a string representation of the worker.
        /// </summary>
        /// <returns>A string representation of the worker.</returns>
        public override string ToString()
        {
            return $"{FirstName,15} {LastName,15} {Age,10} {Salary.ToString("## ###"),10} руб.";
        }
    }
}
