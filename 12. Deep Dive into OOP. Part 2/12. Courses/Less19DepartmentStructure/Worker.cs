using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less19DepartmentStructure
{
    /// <summary>
    /// Represents an employee in the organization.
    /// </summary>
    internal class Worker
    {
        /// <summary>
        /// Gets or sets the name of the worker.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the age of the worker.
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Gets the unique identifier of the department to which the worker belongs.
        /// </summary>
        public int DepartmentId { get; private set; }

        // Uncomment the property below if you want to expose the DepartmentName property.
        // public int DepartamentName
        // {
        //     get
        //     {
        //         // .....
        //     }
        // }

        /// <summary>
        /// Constructor for creating a new instance of the Worker class.
        /// </summary>
        /// <param name="Name">The name of the worker.</param>
        /// <param name="age">The age of the worker.</param>
        /// <param name="DepId">The unique identifier of the department to which the worker belongs.</param>
        public Worker(string Name, int age, int DepId)
        {
            this.Name = Name;
            Age = age;
            this.DepartmentId = DepId;
        }

        /// <summary>
        /// Overrides the default ToString() method to provide a formatted string representation of the worker.
        /// </summary>
        /// <returns>A formatted string containing the worker's name, age, and department ID.</returns>
        public override string ToString()
        {
            return $"{Name,7} {Age,3} {DepartmentId,3}";
        }
    }
}
