using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchyManagementSystem
{
    /// <summary>
    /// Represents an abstract class for an employee in the organization.
    /// </summary>
    public abstract class Employee
    {
        /// <summary>
        /// Static random object for generating random values.
        /// </summary>
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
        /// Gets or sets the salary of the employee (abstract property).
        /// </summary>
        public abstract uint Salary { get; set; }

        /// <summary>
        /// Gets the position or job title of the employee (abstract property).
        /// </summary>
        public abstract string Position { get; }

        /// <summary>
        /// Gets or sets the unique identifier of the employee.
        /// </summary>
        public uint Id { get; set; }

        /// <summary>
        /// Static counter for generating unique IDs.
        /// </summary>
        public static uint count = 0;

        /// <summary>
        /// Represents a constructor for the Employee class.
        /// </summary>
        /// <param name="name">The name of the employee.</param>
        /// <param name="age">The age of the employee.</param>
        /// <param name="projects">The number of projects the employee is involved in.</param>
        /// <param name="depId">The department ID to which the employee belongs.</param>
        protected Employee(string name, byte age, byte projects, uint depId)
        {
            Name = name;
            Age = age;
            Projects = projects;
            DepId = depId;
            Id = ++count;
        }

        /// <summary>
        /// Default constructor with default values.
        /// </summary>
        protected Employee() : this("", 18, 0, 0) 
        { 
        }

        /// <summary>
        /// Constructor with a specified name and default values for other properties.
        /// </summary>
        /// <param name="name">The name of the employee.</param>
        protected Employee(string name) : this(name, (byte)rnd.Next(18, 50), (byte)rnd.Next(1, 10), 0) 
        { 
        }

        /// <summary>
        /// Constructor with a specified name, department ID, and default values for other properties.
        /// </summary>
        /// <param name="name">The name of the employee.</param>
        /// <param name="depId">The department ID to which the employee belongs.</param>
        protected Employee(string name, uint depId) : this(name, (byte)rnd.Next(18, 50), (byte)rnd.Next(1, 10), depId) 
        { 
        }
    }

    /// <summary>
    /// Represents an internal class for the Chief Executive Officer (CEO) who is an employee.
    /// </summary>
    internal class CEO : Employee
    {
        /// <summary>
        /// Constructor for the CEO class with specified parameters.
        /// </summary>
        /// <param name="name">The name of the CEO.</param>
        /// <param name="age">The age of the CEO.</param>
        /// <param name="projects">The number of projects the CEO is involved in.</param>
        /// <param name="depId">The department ID to which the CEO belongs.</param>
        public CEO(string name, byte age, byte projects, uint depId) :
            base(name, age, projects, depId)
        { }

        /// <summary>
        /// Default constructor for the CEO class with default values.
        /// </summary>
        public CEO() : base("Boss", 50, 0, 0) { }

        /// <summary>
        /// Gets or sets the salary of the CEO (fixed salary).
        /// </summary>
        public override uint Salary { get; set; } = 50000;

        /// <summary>
        /// Gets the position or job title of the CEO.
        /// </summary>
        public override string Position { get; } = "CEO";
    }

    /// <summary>
    /// Represents an internal class for an Administrator, a type of employee.
    /// </summary>
    internal class Administrator : Employee
    {
        /// <summary>
        /// Creates an Administrator with specified parameters.
        /// </summary>
        /// <param name="name">The name of the Administrator.</param>
        /// <param name="age">The age of the Administrator.</param>
        /// <param name="projects">The number of projects the Administrator is involved in.</param>
        /// <param name="depId">The department ID to which the Administrator belongs.</param>
        public Administrator(string name, byte age, byte projects, uint depId) :
            base(name, age, projects, depId)
        { }

        /// <summary>
        /// Creates an Administrator with a generated name and specified department ID.
        /// </summary>
        /// <param name="depId">The department ID to which the Administrator belongs.</param>
        public Administrator(uint depId) : base($"Admin_{Guid.NewGuid().ToString().Substring(0, 5)}", depId) { }

        /// <summary>
        /// Creates an Administrator with a generated name.
        /// </summary>
        public Administrator() : base($"Admin_{Guid.NewGuid().ToString().Substring(0, 5)}") { }

        /// <summary>
        /// Gets or sets the salary of the Administrator, which is 15% of the salary of all employees at all sub-departments, but not less than $7000.
        /// </summary>
        public override uint Salary { get; set; } = 7000;

        /// <summary>
        /// Gets the position or job title of the Administrator.
        /// </summary>
        public override string Position { get; } = "Administrator";
    }

    /// <summary>
    /// Represents an internal class for a Manager, a type of employee.
    /// </summary>
    internal class Manager : Employee
    {
        /// <summary>
        /// Creates a Manager with specified parameters.
        /// </summary>
        /// <param name="name">The name of the Manager.</param>
        /// <param name="age">The age of the Manager.</param>
        /// <param name="projects">The number of projects the Manager is involved in.</param>
        /// <param name="depId">The department ID to which the Manager belongs.</param>
        public Manager(string name, byte age, byte projects, uint depId) :
            base(name, age, projects, depId)
        { }

        /// <summary>
        /// Creates a Manager with a generated name and specified department ID.
        /// </summary>
        /// <param name="depId">The department ID to which the Manager belongs.</param>
        public Manager(uint depId) : base($"Manager_{Guid.NewGuid().ToString().Substring(0, 5)}", depId) { }

        /// <summary>
        /// Creates a Manager with a generated name.
        /// </summary>
        public Manager() : base($"Manager_{Guid.NewGuid().ToString().Substring(0, 5)}") { }

        /// <summary>
        /// Gets or sets the fixed salary of the Manager.
        /// </summary>
        public override uint Salary { get; set; } = 5000;

        /// <summary>
        /// Gets the position or job title of the Manager.
        /// </summary>
        public override string Position { get; } = "Manager";
    }


    /// <summary>
    /// Represents an internal class for a Staff, a type of employee.
    /// </summary>
    internal class Staff : Employee
    {
        /// <summary>
        /// Creates a Staff with specified parameters.
        /// </summary>
        /// <param name="name">The name of the Staff.</param>
        /// <param name="age">The age of the Staff.</param>
        /// <param name="projects">The number of projects the Staff is involved in.</param>
        /// <param name="depId">The department ID to which the Staff belongs.</param>
        public Staff(string name, byte age, byte projects, uint depId) :
            base(name, age, projects, depId)
        { }

        /// <summary>
        /// Creates a Staff with a generated name and specified department ID.
        /// </summary>
        /// <param name="depId">The department ID to which the Staff belongs.</param>
        public Staff(uint depId) : base($"Staff_{Guid.NewGuid().ToString().Substring(0, 5)}", depId) { }

        /// <summary>
        /// Creates a Staff with a generated name.
        /// </summary>
        public Staff() : base($"Staff_{Guid.NewGuid().ToString().Substring(0, 5)}") { }

        /// <summary>
        /// Gets or sets the fixed salary of the Staff.
        /// </summary>
        public override uint Salary { get; set; } = 3000;

        /// <summary>
        /// Gets the position or job title of the Staff.
        /// </summary>
        public override string Position { get; } = "Staff";
    }


    /// <summary>
    /// Represents an internal class for an Intern, a type of employee.
    /// </summary>
    internal class Intern : Employee
    {
        /// <summary>
        /// Creates an Intern with specified parameters.
        /// </summary>
        /// <param name="name">The name of the Intern.</param>
        /// <param name="age">The age of the Intern.</param>
        /// <param name="projects">The number of projects the Intern is involved in.</param>
        /// <param name="depId">The department ID to which the Intern belongs.</param>
        public Intern(string name, byte age, byte projects, uint depId) :
            base(name, age, projects, depId)
        { }

        /// <summary>
        /// Creates an Intern with a generated name and specified department ID.
        /// </summary>
        /// <param name="depId">The department ID to which the Intern belongs.</param>
        public Intern(uint depId) : base($"Intern_{Guid.NewGuid().ToString().Substring(0, 5)}", depId) { }

        /// <summary>
        /// Creates an Intern with a generated name.
        /// </summary>
        public Intern() : base($"Intern_{Guid.NewGuid().ToString().Substring(0, 5)}") { }

        /// <summary>
        /// Gets or sets the fixed salary of the Intern.
        /// </summary>
        public override uint Salary { get; set; } = 1000;

        /// <summary>
        /// Gets the position or job title of the Intern.
        /// </summary>
        public override string Position { get; } = "Intern";
    }
}
