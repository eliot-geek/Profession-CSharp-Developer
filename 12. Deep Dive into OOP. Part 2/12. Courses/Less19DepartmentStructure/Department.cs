using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less19DepartmentStructure
{
    /// <summary>
    /// Represents a department in the organization.
    /// </summary>
    internal class Department
    {
        /// <summary>
        /// Gets or sets the name of the department.
        /// </summary>
        public string DepartmentName { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the department.
        /// </summary>
        public int DepartmentId { get; set; }

        /// <summary>
        /// Constructor for creating a new Department instance.
        /// </summary>
        /// <param name="Name">The name of the department.</param>
        /// <param name="Id">The unique identifier of the department.</param>
        public Department(string Name, int Id)
        {
            DepartmentName = Name;
            DepartmentId = Id;
        }

        /// <summary>
        /// Overrides the default ToString() method to provide a formatted string representation of the department.
        /// </summary>
        /// <returns>A formatted string containing the department's name and ID.</returns>
        public override string ToString()
        {
            return $"{DepartmentName,15} {DepartmentId,3}";
        }
    }
}
