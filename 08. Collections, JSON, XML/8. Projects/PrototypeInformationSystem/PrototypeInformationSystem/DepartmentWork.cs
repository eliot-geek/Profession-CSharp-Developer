using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeInformationSystem
{
    internal class DepartmentWork
    {
        public List<Department> departments;

        public int count;

        /// <summary>
        /// Constructor for the DepartmentWork class.
        /// </summary>
        /// <param name="count">The initial count value for department creation.</param>
        public DepartmentWork(int count)
        {
            departments = new List<Department>();
            this.count = count;
        }

        /// <summary>
        /// Adds a new department to the organizational structure.
        /// </summary>
        /// <param name="Name">The name of the department.</param>
        /// <param name="data">The creation date of the department.</param>
        /// <param name="QuantityWorker">The initial quantity of workers in the department.</param>
        public void AddDepartments(string Name, DateTime data, int QuantityWorker)
        {
            departments.Add(new Department(Name, data, QuantityWorker, count));
            count++;
        }

        /// <summary>
        /// Displays information about departments and employees.
        /// </summary>
        public void PrintFullInfoDepartments()
        {
            Console.Clear();
            Console.WriteLine("1 - Information about all departments and employees");
            Console.WriteLine("2 - Information about a separate department");

            int i = int.Parse(Console.ReadLine());
            
            if (i == 1)
            {
                Console.Clear();
                foreach (var item in departments)
                {
                    item.PrintAllInfo();
                }
            }
            else
            {
                Console.Clear();
                Console.Write("Enter department's Id : ");
                int t = int.Parse(Console.ReadLine());
                t--;
                departments[t].PrintAllInfo();
            }

        }

        /// <summary>
        /// Displays information about all departments without employees.
        /// </summary>
        public void PrintAllDepartments()
        {
            Console.WriteLine("\t\tInformation about departments");
            foreach (var item in departments)
            {
                item.PrintDepartments();
                Console.WriteLine("---------------------------------------");
            }
        }

        /// <summary>
        /// Displays information about all employees in all departments.
        /// </summary>
        public void PrintAllWorker()
        {
            List<Worker> workers = new List<Worker>();

            foreach (var item in departments)
            {
                foreach (var item2 in item.workers)
                {
                    workers.Add(item2);
                }

            }
            
            int id = 0;
            foreach (var item in workers)
            {
                item.Print();
                id++;
            }
            
            Console.WriteLine($"\nTotal number of employees in all departments : {id}");
        }

        /// <summary>
        /// Edits a department's information.
        /// </summary>
        public void EditDeparts()
        {
            Console.Write("Enter the department's number you want to edit : ");
            int i = int.Parse(Console.ReadLine());
            i--;
            Department department = departments[i];
            Department.EditDepartment(ref department);
            departments[i] = department;
        }

        /// <summary>
        /// Edits an employee within a department.
        /// </summary>
        public void EditEmployee()
        {
            Console.Write("Enter the number of the department in which you want to edit the employee : ");
            int i = int.Parse(Console.ReadLine());
            i--;

            Console.Write("Enter the number of the employee you want to edit : ");
            int j = int.Parse(Console.ReadLine());

            Worker work = departments[i].workers[j];
            Worker.EditWorker(ref work);
            departments[i].workers[j] = work;
        }

        /// <summary>
        /// Deletes a department.
        /// </summary>
        public void RemoveDepartment()
        {
            Console.Write("Enter the department's number you want to delete : ");
            int i = int.Parse(Console.ReadLine());

            departments.RemoveAt(--i);
            count--;
        }

        /// <summary>
        /// Deletes an employee from a department.
        /// </summary>
        public void RemoveWorker()
        {
            Console.Write("Enter the number of the department in which you want to delete the employee : ");
            int i = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of the employee you want to delete : ");
            int j = int.Parse(Console.ReadLine());

            departments[--i].workers.RemoveAt(--j);
        }

        /// <summary>
        /// Sorts employees in a department by salary.
        /// </summary>
        public void SortWorkerBySalary()
        {
            Console.Write("Enter the number of the department in which you want to sort employees : ");
            int i = int.Parse(Console.ReadLine());
            i--;

            departments[i].SortedWorkersBySalary();
        }

        /// <summary>
        /// Sorts employees in a department by age.
        /// </summary>
        public void SortWorkerByAge()
        {
            Console.Write("Enter the number of the department in which you want to sort employees : ");
            int i = int.Parse(Console.ReadLine());
            i--;

            departments[i].SortedWorkersByAge();
        }

        /// <summary>
        /// Sorts employees in a department by name.
        /// </summary>
        public void SortWorkerByName()
        {
            Console.Write("Enter the number of the department in which you want to sort employees : ");
            int i = int.Parse(Console.ReadLine());
            i--;

            departments[i].SortedWorkersByName();
        }

        /// <summary>
        /// Sorts employees in a department by last name.
        /// </summary>
        public void SortWorkerByLastName()
        {
            Console.Write("Enter the number of the department in which you want to sort employees : ");
            int i = int.Parse(Console.ReadLine());
            i--;

            departments[i].SortedWorkersByLastName();
        }

        /// <summary>
        /// Sorts employees in a department by department.
        /// </summary>
        public void SortWorkerByDepartment()
        {
            Console.Write("Enter the number of the department in which you want to sort employees : ");
            int i = int.Parse(Console.ReadLine());
            i--;

            departments[i].SortedWorkersByDepartment();
        }

        /// <summary>
        /// Sorts employees in a department by ID.
        /// </summary>
        public void SortWorkerByID()
        {
            Console.Write("Enter the number of the department in which you want to sort employees : ");
            int i = int.Parse(Console.ReadLine());
            i--;

            departments[i].SortedWorkersByID();
        }

        /// <summary>
        /// Serializes the data to a JSON file.
        /// </summary>
        public void SerializeJson()
        {
            string file = "file";
            string json = JsonConvert.SerializeObject(departments);
            File.WriteAllText($@"{file}.json", json);
        }

        /// <summary>
        /// Deserializes data from a JSON file.
        /// </summary>
        public void DeserializeJson()
        {
            string file = "file";
            string json = File.ReadAllText($"{file}.json");
            departments = JsonConvert.DeserializeObject<List<Department>>(json);
        }
    }
}
