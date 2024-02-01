using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchyManagementSystem
{
    /// <summary>
    /// Abstract class representing an Employee in the organization.
    /// </summary>
    public abstract class Employee
    {
        static Random rnd = new Random();

        /// <summary>
        /// Gets or sets the name of the employee.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the age of the employee.
        /// </summary>
        public byte Age { get; set; }

        /// <summary>
        /// Gets or sets the number of projects the employee is involved in.
        /// </summary>
        public byte Projects { get; set; }

        /// <summary>
        /// Gets or sets the department ID to which the employee belongs.
        /// </summary>
        public uint DepId { get; set; }

        /// <summary>
        /// Gets or sets the abstract property representing the salary of the employee.
        /// </summary>
        public abstract uint Salary { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the employee.
        /// </summary>
        public uint Id { get; set; }

        /// <summary>
        /// Static counter to assign unique IDs to employees.
        /// </summary>
        public static uint count = 0;

        /// <summary>
        /// Constructor for creating an Employee instance with specified details.
        /// </summary>
        /// <param name="name">Employee's name.</param>
        /// <param name="age">Employee's age.</param>
        /// <param name="projects">Number of projects the employee is involved in.</param>
        /// <param name="depId">Department ID to which the employee belongs.</param>
        protected Employee(string name, byte age, byte projects, uint depId)
        {
            Name = name;
            Age = age;
            Projects = projects;
            DepId = depId;
            Id = ++count;
        }

        /// <summary>
        /// Default constructor initializing with default values.
        /// </summary>
        protected Employee() : this("", 18, 0, 0) { }

        /// <summary>
        /// Constructor initializing with a specified name.
        /// </summary>
        /// <param name="name">Employee's name.</param>
        protected Employee(string name) : this(name, (byte)rnd.Next(18, 50), (byte)rnd.Next(1, 10), 0) { }

        /// <summary>
        /// Constructor initializing with a specified name and department ID.
        /// </summary>
        /// <param name="name">Employee's name.</param>
        /// <param name="depId">Department ID to which the employee belongs.</param>
        protected Employee(string name, uint depId) : this(name, (byte)rnd.Next(18, 50), (byte)rnd.Next(1, 10), depId) { }
    }

    /// <summary>
    /// Represents the CEO (Chief Executive Officer) of the organization.
    /// </summary>
    internal class CEO : Employee
    {
        /// <summary>
        /// Creates a CEO with specified details.
        /// </summary>
        /// <param name="name">CEO's name.</param>
        /// <param name="age">CEO's age.</param>
        /// <param name="projects">Number of projects the CEO is involved in.</param>
        /// <param name="depId">Department ID to which the CEO belongs.</param>
        public CEO(string name, byte age, byte projects, uint depId) :
            base(name, age, projects, depId)
        { }

        /// <summary>
        /// Default constructor initializing a CEO with default values.
        /// </summary>
        public CEO() : base("Boss", 50, 0, 0) { }

        /// <summary>
        /// Gets or sets the salary of the CEO (fixed salary).
        /// </summary>
        public override uint Salary { get; set; } = 50000;

        /// <summary>
        /// Gets the position of the CEO.
        /// </summary>
        public string Position { get; } = "CEO";
    }

    /// <summary>
    /// Represents an Administrator in the organization.
    /// </summary>
    internal class Administrator : Employee
    {
        /// <summary>
        /// Creates an administrator with specified details.
        /// </summary>
        /// <param name="name">Administrator's name.</param>
        /// <param name="age">Administrator's age.</param>
        /// <param name="projects">Number of projects the administrator is involved in.</param>
        /// <param name="depId">Department ID to which the administrator belongs.</param>
        public Administrator(string name, byte age, byte projects, uint depId) :
            base(name, age, projects, depId)
        { }

        /// <summary>
        /// Creates an administrator with a specified department ID.
        /// </summary>
        /// <param name="depId">Department ID to which the administrator belongs.</param>
        public Administrator(uint depId) : base($"Admin_{Guid.NewGuid().ToString().Substring(0, 5)}", depId) { }

        /// <summary>
        /// Creates an administrator with a unique name.
        /// </summary>
        public Administrator() : base($"Admin_{Guid.NewGuid().ToString().Substring(0, 5)}") { }

        /// <summary>
        /// Gets or sets the salary of the administrator (15% of salary of all employees at all sub-departments, but not less than 7000$).
        /// </summary>
        public override uint Salary { get; set; } = 7000;

        /// <summary>
        /// Gets the position of the administrator.
        /// </summary>
        public string Position { get; } = "Administrator";
    }

    /// <summary>
    /// Represents a Manager in the organization.
    /// </summary>
    internal class Manager : Employee
    {
        /// <summary>
        /// Creates a manager with specified details.
        /// </summary>
        /// <param name="name">Manager's name.</param>
        /// <param name="age">Manager's age.</param>
        /// <param name="projects">Number of projects the manager is involved in.</param>
        /// <param name="depId">Department ID to which the manager belongs.</param>
        public Manager(string name, byte age, byte projects, uint depId) :
            base(name, age, projects, depId)
        { }

        /// <summary>
        /// Creates a manager with a specified department ID.
        /// </summary>
        /// <param name="depId">Department ID to which the manager belongs.</param>
        public Manager(uint depId) : base($"Admin_{Guid.NewGuid().ToString().Substring(0, 5)}", depId) { }

        /// <summary>
        /// Creates a manager with a unique name.
        /// </summary>
        public Manager() : base($"Manager_{Guid.NewGuid().ToString().Substring(0, 5)}") { }

        /// <summary>
        /// Gets or sets the salary of the manager (fixed salary).
        /// </summary>
        public override uint Salary { get; set; } = 5000;

        /// <summary>
        /// Gets the position of the manager.
        /// </summary>
        public string Position { get; } = "Manager";
    }

    /// <summary>
    /// Represents a Staff member in the organization.
    /// </summary>
    internal class Staff : Employee
    {
        /// <summary>
        /// Creates a staff member with specified details.
        /// </summary>
        /// <param name="name">Staff member's name.</param>
        /// <param name="age">Staff member's age.</param>
        /// <param name="projects">Number of projects the staff member is involved in.</param>
        /// <param name="depId">Department ID to which the staff member belongs.</param>
        public Staff(string name, byte age, byte projects, uint depId) :
            base(name, age, projects, depId)
        { }

        /// <summary>
        /// Creates a staff member with a specified department ID.
        /// </summary>
        /// <param name="depId">Department ID to which the staff member belongs.</param>
        public Staff(uint depId) : base($"Admin_{Guid.NewGuid().ToString().Substring(0, 5)}", depId) { }

        /// <summary>
        /// Creates a staff member with a unique name.
        /// </summary>
        public Staff() : base($"Staff_{Guid.NewGuid().ToString().Substring(0, 5)}") { }

        /// <summary>
        /// Gets or sets the salary of the staff member (fixed salary).
        /// </summary>
        public override uint Salary { get; set; } = 3000;

        /// <summary>
        /// Gets the position of the staff member.
        /// </summary>
        public string Position { get; } = "Staff";
    }

    /// <summary>
    /// Represents an Intern in the organization.
    /// </summary>
    internal class Intern : Employee
    {
        /// <summary>
        /// Creates an intern with specified details.
        /// </summary>
        /// <param name="name">Intern's name.</param>
        /// <param name="age">Intern's age.</param>
        /// <param name="projects">Number of projects the intern is involved in.</param>
        /// <param name="depId">Department ID to which the intern belongs.</param>
        public Intern(string name, byte age, byte projects, uint depId) :
            base(name, age, projects, depId)
        { }

        /// <summary>
        /// Creates an intern with a specified department ID.
        /// </summary>
        /// <param name="depId">Department ID to which the intern belongs.</param>
        public Intern(uint depId) : base($"Admin_{Guid.NewGuid().ToString().Substring(0, 5)}", depId) { }

        /// <summary>
        /// Creates an intern with a unique name.
        /// </summary>
        public Intern() : base($"Intern_{Guid.NewGuid().ToString().Substring(0, 5)}") { }

        /// <summary>
        /// Gets or sets the salary of the intern (fixed salary).
        /// </summary>
        public override uint Salary { get; set; } = 1000;

        /// <summary>
        /// Gets the position of the intern.
        /// </summary>
        public string Position { get; } = "Intern";
    }
}
