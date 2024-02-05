using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchyManagementSystem
{
    /// <summary>
    /// Represents an organisation with its properties and methods related to employee management.
    /// </summary>
    class Organisation
    {
        /// <summary>
        /// Gets or sets the title of the organisation.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the organisation.
        /// </summary>
        public uint Id { get; set; }

        /// <summary>
        /// Gets or sets the parent identifier of the organisation.
        /// </summary>
        public uint ParId { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the administrator associated with the organisation.
        /// </summary>
        public uint AdministratorId { get; set; }

        /// <summary>
        /// Gets or sets the collection of employees within the organisation.
        /// </summary>
        public ObservableCollection<Employee> Employees { get; set; }

        /// <summary>
        /// Gets or sets the static count for generating unique IDs for organisations.
        /// </summary>
        public static uint count = 0;

        /// <summary>
        /// Gets or sets the flag indicating if the salary is calculated in the current department.
        /// </summary>
        public bool SalaryFlag { get; set; }

        /// <summary>
        /// Gets or sets the total salary amount of all employees in the current department.
        /// </summary>
        public uint SalaryAmount { get; set; }

        /// <summary>
        /// Initializes a new instance of the Organisation class with a specified title.
        /// </summary>
        /// <param name="title">The title of the organisation.</param>
        public Organisation(string title)
        {
            Title = title;
            Id = ++count; // Increment the count to generate a unique ID
            Employees = new ObservableCollection<Employee>();
        }

        /// <summary>
        /// Initializes a new instance of the Organisation class with a default title.
        /// </summary>
        public Organisation() : this($"dep{count}") { }
    }
}
