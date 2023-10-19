using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01EmployeeManagementSystem
{
    /// <summary>
    /// Class describing the employee model
    /// </summary>
    internal class Employee
    {
        /// <summary>
        /// Employee's name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Employee's last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Employee's age
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Employee's salary
        /// </summary>
        public int Salary { get; set; }

        /// <summary>
        /// A constructor that allows you to assign a value to the corresponding fields of the employee
        /// </summary>
        /// <param name="FirstName">Name</param>
        /// <param name="LastName">Lastname</param>
        /// <param name="Age">Age</param>
        /// <param name="Salary">Salary</param>
        public Employee(string FirstName, string LastName, int Age, int Salary)
        {
            this.FirstName = FirstName; // Save the passed name value
            this.LastName = LastName;   // Save the passed lastname value
            this.Age = Age;             // Save the passed age value
            this.Salary = Salary;       // Save the passed salary value
        }

        /// <summary>
        /// Organization of the output of information about the employee
        /// </summary>
        /// <returns>String representation of information</returns>
        public override string ToString()
        {
            return $"{FirstName,15} {LastName,15} {Age,10} {Salary.ToString("## ###"),10} $.";
        }
    }
}
