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
        /// ID
        /// </summary>
        private int id;
        
        /// <summary>
        /// Name
        /// </summary>
        private string name;
        
        /// <summary>
        /// LastName
        /// </summary>
        private string lastName;
        
        /// <summary>
        /// Department
        /// </summary>
        private int department;
        
        /// <summary>
        /// Age
        /// </summary>
        private int age;
        
        /// <summary>
        /// Salary
        /// </summary>
        private int salary;
        
        /// <summary>
        /// Project
        /// </summary>
        private int project;

        /// <summary>
        /// By default
        /// </summary>
        public Worker()
        {

        }

        /// <summary>
        /// Worker's Constructor
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Name"></param>
        /// <param name="LastName"></param>
        /// <param name="Department"></param>
        /// <param name="Age"></param>
        /// <param name="Salary"></param>
        /// <param name="Project"></param>
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
        /// Print Employees
        /// </summary>
        /// <param name="worker"></param>
        static void PrintWorkers(Worker worker)
        {
            worker.Print();
        }

        /// <summary>
        /// Edit Employees
        /// </summary>
        /// <param name="worker"></param>
        /// <returns></returns>
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
        /// Print
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"{this.Id,2}{this.Name,10}{this.LastName,18}{this.Age,12}{"",9}" +
                $"Department_{this.Department}{this.Salary,14}{this.Project,11}");
        }

        /// <summary>
        /// ID
        /// </summary>
        public int Id { get { return this.id; } set { this.id = value; } }
        
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get { return this.name; } set { this.name = value; } }
        
        /// <summary>
        /// LastName
        /// </summary>
        public string LastName { get { return this.lastName; } set { this.lastName = value; } }
        
        /// <summary>
        /// Department
        /// </summary>
        public int Department { get { return this.department; } set { this.department = value; } }
        
        /// <summary>
        /// Age
        /// </summary>
        public int Age { get { return this.age; } set { this.age = value; } }
        
        /// <summary>
        /// Salary
        /// </summary>
        public int Salary { get { return this.salary; } set { this.salary = value; } }
        
        /// <summary>
        /// Project
        /// </summary>
        public int Project { get { return this.project; } set { this.project = value; } }

    }
}
