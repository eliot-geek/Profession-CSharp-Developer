namespace PrototypeInformationSystem
{
    internal class Program
    {
        /// <summary>
        /// Adds a department to the organizational structure.
        /// </summary>
        /// <param name="department">The department to be added.</param>
        /// <returns>The updated DepartmentWork object with the new department added.</returns>
        public static DepartmentWork AddDepartments(ref DepartmentWork department)
        {
            Console.Clear();
            Console.Write("Enter the Department's name: ");
            string name = Console.ReadLine();
            Console.Write("Enter the Department's creation date (yyyy-MM-dd): ");
            string inputDate = Console.ReadLine();
            DateTime data;

            if (DateTime.TryParse(inputDate, out data))
            {
                Console.Write("Enter the quantity of employees: ");
                int Count = int.Parse(Console.ReadLine());
                department.AddDepartments(name, data, Count);
                Console.WriteLine($"Department {name} with {Count} employees added!");
            }
            else
            {
                Console.WriteLine("Invalid date format. Please enter a date in the format 'yyyy-MM-dd'.");
            }
            Console.Clear();
            return department;
        }


        static void Main(string[] args)
        {
            DepartmentWork department = new DepartmentWork(1);
            int count = 0;
            bool check = true;
            while (true)
            {
                Console.WriteLine("01 - Add a Department\n02 - Print Departments\n03 - Print Departments with Employees\n" +
                    "04 - Print All Employees from All Departments\n05 - Edit a Department\n06 - Edit an Employee within a Department\n" +
                    "07 - Delete a Department\n08 - Delete an Employee from a Department\n09 - Sort All Employees by Salary\n" +
                    "10 - Sort All Employees by Age\n11 - Sort All Employees by Name\n12 - Sort All Employees by LastName\n13 - Sort All Employees by Department\n" +
                    "14 - Sort All Employees by ID\n15 - Import Information\n16 - Save Information in a JSON File\nPress any other to exit the program");

                string choice = Convert.ToString(Console.ReadLine());
                if (choice == "01")
                {
                    count++;
                    department = AddDepartments(ref department);
                    check = false;

                }
                else if (choice == "02")
                {
                    if (check)
                    {
                        Console.Clear();
                        Console.WriteLine("There are no departments!");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    Console.Clear();
                    department.PrintAllDepartments();
                    Console.ReadLine();
                    Console.Clear();

                }
                else if (choice == "03")
                {
                    if (check)
                    {
                        Console.Clear();
                        Console.WriteLine("There are no departments!");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    Console.Clear();
                    department.PrintFullInfoDepartments();
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (choice == "04")
                {
                    if (check)
                    {
                        Console.Clear();
                        Console.WriteLine("There are no departments!");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    Console.Clear();
                    department.PrintAllWorker();
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (choice == "05")
                {
                    if (check)
                    {
                        Console.Clear();
                        Console.WriteLine("There are no departments!");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    Console.Clear();
                    department.EditDeparts();
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (choice == "06")
                {
                    if (check)
                    {
                        Console.Clear();
                        Console.WriteLine("There are no departments!");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    Console.Clear();
                    department.EditEmployee();
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (choice == "07")
                {
                    if (check)
                    {
                        Console.Clear();
                        Console.WriteLine("There are no departments!");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    Console.Clear();
                    department.RemoveDepartment();
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (choice == "08")
                {
                    if (check)
                    {
                        Console.Clear();
                        Console.WriteLine("There are no departments!");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    Console.Clear();
                    department.RemoveWorker();
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (choice == "09")
                {
                    if (check)
                    {
                        Console.Clear();
                        Console.WriteLine("There are no departments!");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    Console.Clear();
                    department.SortWorkerBySalary();
                    Console.WriteLine("Employees are sorted!");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (choice == "10")
                {
                    if (check)
                    {
                        Console.Clear();
                        Console.WriteLine("There are no departments!");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    Console.Clear();
                    department.SortWorkerByAge();
                    Console.WriteLine("Employees are sorted!");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (choice == "11")
                {
                    if (check)
                    {
                        Console.Clear();
                        Console.WriteLine("There are no departments!");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    Console.Clear();
                    department.SortWorkerByName();
                    Console.WriteLine("Employees are sorted!");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (choice == "12")
                {
                    if (check)
                    {
                        Console.Clear();
                        Console.WriteLine("There are no departments!");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    Console.Clear();
                    department.SortWorkerByLastName();
                    Console.WriteLine("Employees are sorted!");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (choice == "13")
                {
                    if (check)
                    {
                        Console.Clear();
                        Console.WriteLine("There are no departments!");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    Console.Clear();
                    department.SortWorkerByDepartment();
                    Console.WriteLine("Employees are sorted!");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (choice == "14")
                {
                    if (check)
                    {
                        Console.Clear();
                        Console.WriteLine("There are no departments!");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    Console.Clear();
                    department.SortWorkerByID();
                    Console.WriteLine("Employees are sorted!");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (choice == "15")
                {
                    Console.Clear();
                    department.DeserializeJson();
                    Console.WriteLine("The file has been successfully");
                    Console.ReadLine();
                    check = false;
                    Console.Clear();
                }
                else if (choice == "16")
                {
                    if (check)
                    {
                        Console.Clear();
                        Console.WriteLine("You are trying to write an empty file!");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    department.SerializeJson();
                    Console.WriteLine("The file has been saved successfully");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("End!!");
                    break;
                }
            }

        }
    }
}