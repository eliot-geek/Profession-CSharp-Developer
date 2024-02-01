using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchyManagementSystem
{
    /// <summary>
    /// Represents an organization within the information system.
    /// </summary>
    public class Organisation
    {
        /// <summary>
        /// Gets or sets the name of the organization.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the organization.
        /// </summary>
        public uint Id { get; set; }

        /// <summary>
        /// Gets or sets the parent organization's identifier.
        /// </summary>
        public uint ParId { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the administrator of the organization.
        /// </summary>
        public uint AdministratorId { get; set; }

        /// <summary>
        /// Gets or sets the collection of employees in the organization.
        /// </summary>
        public ObservableCollection<Employee> Employees { get; set; }

        /// <summary>
        /// Gets or sets a static counter to assign unique IDs to organizations.
        /// </summary>
        public static uint count = 0;

        /// <summary>
        /// Gets or sets a flag indicating whether salary is counted in the current department.
        /// true if the salary is counted in current department
        /// </summary>
        public bool SalaryFlag { get; set; }

        /// <summary>
        /// Gets or sets the total salary amount of all employees in the current department.
        /// salary amount of all employees in current department
        /// </summary>
        public uint SalaryAmount { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Organisation"/> class with a specified title.
        /// </summary>
        /// <param name="title">The name of the organization.</param>
        public Organisation(string title)
        {
            Title = title;
            Id = ++count;
            Employees = new ObservableCollection<Employee>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Organisation"/> class with a default title.
        /// </summary>
        public Organisation() : this($"dep{count}") { }
    }

}
