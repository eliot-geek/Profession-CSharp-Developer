using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeInformationSystem
{
    internal class Department
    {
        /// <summary>
        /// List of workers
        /// </summary>
        public List<Worker> workers;

        /// <summary>
        /// Name
        /// </summary>
        private string name;
        
        /// <summary>
        /// DateTime
        /// </summary>
        private DateTime date;
        
        /// <summary>
        /// Quantity Worker
        /// </summary>
        private int quantityWorker;
        
        /// <summary>
        /// Count
        /// </summary>
        private int count;

        /// <summary>
        /// Constructor for the Department class.
        /// </summary>
        /// <param name="Name">The name of the department.</param>
        /// <param name="Date">The creation date of the department.</param>
        /// <param name="QuantityWorker">The total quantity of workers the department can have.</param>
        /// <param name="Count">The initial count of workers to be added to the department.</param>
        public Department(string Name, DateTime Date, int QuantityWorker, int Count)
        {
            this.Name = Name;
            this.Date = Date;
            this.QuantityWorker = QuantityWorker;
            this.Count = Count;

            Storage rep = new Storage(QuantityWorker);
            workers = new List<Worker>();
            workers = (rep.Add(this.Count));
        }

        /// <summary>
        /// Default constructor for the Department class.
        /// </summary>
        public Department() { }

        /// <summary>
        /// Displays comprehensive information about the department and its employees.
        /// </summary>
        public void PrintAllInfo()
        {
            Console.WriteLine("\t\tInformation about the organization");
            Console.WriteLine($"Organisation's name : {this.Name}");
            Console.WriteLine($"Date of Creation : {this.Date.ToShortDateString()}");
            Console.WriteLine($"Number of employees : {this.QuantityWorker}");
            Console.WriteLine($"\n\t\t\tInformation about employees\n");
            Console.WriteLine($"Id{"",5} Name{"",10} LastName{"",5}   Age{"",5} Department{"",5}  Salary{"",5}  Projects");

            foreach (var item in workers)
            {
                item.Print();
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Displays information about the current department.
        /// </summary>
        public void PrintDepartments()
        {
            Console.WriteLine($"Department's name : {this.Name,17}");
            Console.WriteLine($"Date of creation : {this.Date.ToShortDateString(),18}");
            Console.WriteLine($"Number of employees : {this.QuantityWorker,15}");
        }

        /// <summary>
        /// Displays information about all employees from all departments.
        /// </summary>
        public void PrintAllWorkers()
        {
            Console.WriteLine($"Id{"",5} Name{"",10} LastName{"",5} Age{"",5} Department{"",5}Salary{"",5}Projects");

            foreach (var item in workers)
            {
                item.Print();
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Edits the department details.
        /// </summary>
        /// <param name="department">The department to be edited.</param>
        /// <returns>The updated Department object.</returns>
        public static Department EditDepartment(ref Department department)
        {
            Console.WriteLine("\tOld department data");
            department.PrintDepartments();
            Console.WriteLine();

            Console.Write("Enter new department's name : ");
            department.Name = Console.ReadLine();
            Console.Write("Enter new department's date : ");
            department.Date = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter a new number of employees : ");
            department.QuantityWorker = int.Parse(Console.ReadLine());

            Storage rep = new Storage(department.QuantityWorker);
            department.workers = (rep.Add(department.QuantityWorker));
            return department;
        }

        /// <summary>
        /// Sorts employees in the department by salary.
        /// </summary>
        public void SortedWorkersBySalary()
        {
            var SortBySalary = from s in workers
                               orderby s.Salary
                               select s;
            
            int count = 0;

            foreach (var item in SortBySalary)
            {
                workers[count] = item;
                count++;
            }
        }

        /// <summary>
        /// Sorts employees in the department by age
        /// </summary>
        public void SortedWorkersByAge()
        {
            var SortByAge = from s in workers
                               orderby s.Age
                               select s;
            
            int count = 0;

            foreach (var item in SortByAge)
            {
                workers[count] = item;
                count++;
            }
        }

        /// <summary>
        /// Sorts employees in the department alphabetically by name.
        /// </summary>
        public void SortedWorkersByName()
        {
            var SortByName = from s in workers
                               orderby s.Name
                               select s;
            
            int count = 0;
            
            foreach (var item in SortByName)
            {
                workers[count] = item;
                count++;
            }
        }

        /// <summary>
        /// Sorts employees in the department alphabetically by last name.
        /// </summary>
        public void SortedWorkersByLastName()
        {
            var SortByLastName = from s in workers
                               orderby s.LastName
                               select s;
            
            int count = 0;
            
            foreach (var item in SortByLastName)
            {
                workers[count] = item;
                count++;
            }
        }

        /// <summary>
        /// Sorts employees in the department alphabetically by department name.
        /// </summary>
        public void SortedWorkersByDepartment()
        {
            var SortByDepartment = from s in workers
                               orderby s.Department
                               select s;
            
            int count = 0;
            
            foreach (var item in SortByDepartment)
            {
                workers[count] = item;
                count++;
            }
        }

        /// <summary>
        /// Sorts employees in the department by their ID in ascending order.
        /// </summary>
        public void SortedWorkersByID()
        {
            var SortByID = from s in workers
                           orderby s.Id
                           select s;

            int count = 0;

            foreach (var item in SortByID)
            {
                workers[count] = item;
                count++;
            }
        }

        /// <summary>
        /// Gets or sets the name of the department.
        /// </summary>
        public string Name { get { return this.name; } set { this.name = value; } }

        /// <summary>
        /// Gets or sets the creation date of the department.
        /// </summary>
        public DateTime Date { get { return this.date; } set { this.date = value; } }

        /// <summary>
        /// Gets or sets the quantity of workers in the department.
        /// </summary>
        public int QuantityWorker { get { return this.quantityWorker; } set { this.quantityWorker = value; } }

        /// <summary>
        /// Gets or sets the count value.
        /// </summary>
        public int Count { get { return this.count; } set { this.count = value; } }

    }
}
