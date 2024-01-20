using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeInformationSystem
{
    internal class Worker
    {
        /// <summary>
        /// Gets or sets the ID of the worker.
        /// </summary>
        private int id;

        /// <summary>
        /// Gets or sets the name of the worker.
        /// </summary>
        private string name;

        /// <summary>
        /// Gets or sets the last name of the worker.
        /// </summary>
        private string lastName;

        /// <summary>
        /// Gets or sets the department of the worker.
        /// </summary>
        private int department;

        /// <summary>
        /// Gets or sets the age of the worker.
        /// </summary>
        private int age;

        /// <summary>
        /// Gets or sets the salary of the worker.
        /// </summary>
        private int salary;

        /// <summary>
        /// Gets or sets the project of the worker.
        /// </summary>
        private int project;

        /// <summary>
        /// Default constructor for the Worker class.
        /// </summary>
        public Worker()
        {

        }

        /// <summary>
        /// Constructor for the Worker class.
        /// </summary>
        /// <param name="Id">The ID of the worker.</param>
        /// <param name="Name">The name of the worker.</param>
        /// <param name="LastName">The last name of the worker.</param>
        /// <param name="Department">The department of the worker.</param>
        /// <param name="Age">The age of the worker.</param>
        /// <param name="Salary">The salary of the worker.</param>
        /// <param name="Project">The project of the worker.</param>
        public Worker(int Id, string Name, string LastName, int Department, int Age, int Salary, int Project)
        {
            this.Id = Id;
            this.Name = Name;
            this.LastName = LastName;
            this.Department = Department;
            this.Age = Age;
            this.Salary = Salary;
            this.Project = Project;
        }

        /// <summary>
        /// Prints information about the worker.
        /// </summary>
        /// <param name="worker">The worker to be printed.</param>
        static void PrintWorkers(Worker worker)
        {
            worker.Print();
        }


        /// <summary>
        /// Edits employee information.
        /// </summary>
        /// <param name="worker">The worker object to be edited.</param>
        /// <returns>The updated Worker object.</returns>
        public static Worker EditWorker(ref Worker worker)
        {
            Console.WriteLine("\tOld data : ");
            worker.Print();
            Console.WriteLine();

            Console.WriteLine("\tEnter New data : ");
            Console.Write("Enter worker's name : ");
            worker.Name = Console.ReadLine();
            Console.Write("Enter worker's LastName : ");
            worker.LastName = Console.ReadLine();
            Console.Write("Enter worker's age : ");
            worker.Age = int.Parse(Console.ReadLine());
            Console.Write("Enter worker's salary : ");
            worker.Salary = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of employee projects : ");
            worker.Project = int.Parse(Console.ReadLine());

            return worker;
        }

        /// <summary>
        /// Prints the information of the employee.
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"{this.Id,2}{this.Name,10}{this.LastName,18}{this.Age,12}{"",9}" +
                $"Department_{this.Department}{this.Salary,14}{this.Project,11}");
        }

        /// <summary>
        /// Gets or sets the ID of the employee.
        /// </summary>
        public int Id { get { return this.id; } set { this.id = value; } }

        /// <summary>
        /// Gets or sets the name of the employee.
        /// </summary>
        public string Name { get { return this.name; } set { this.name = value; } }

        /// <summary>
        /// Gets or sets the last name of the employee.
        /// </summary>
        public string LastName { get { return this.lastName; } set { this.lastName = value; } }

        /// <summary>
        /// Gets or sets the department ID of the employee.
        /// </summary>
        public int Department { get { return this.department; } set { this.department = value; } }

        /// <summary>
        /// Gets or sets the age of the employee.
        /// </summary>
        public int Age { get { return this.age; } set { this.age = value; } }

        /// <summary>
        /// Gets or sets the salary of the employee.
        /// </summary>
        public int Salary { get { return this.salary; } set { this.salary = value; } }

        /// <summary>
        /// Gets or sets the number of projects of the employee.
        /// </summary>
        public int Project { get { return this.project; } set { this.project = value; } }

    }
}
