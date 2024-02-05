using HierarchyManagementSystem;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchyManagementSystem
{
    /// <summary>
    /// Interface for input/output operations.
    /// </summary>
    interface IIO
    {
        /// <summary>
        /// Save data operation.
        /// </summary>
        void SaveData();

        /// <summary>
        /// Load data operation that returns an ObservableCollection of Organisation.
        /// </summary>
        /// <returns>ObservableCollection of Organisation</returns>
        ObservableCollection<Organisation> LoadData();
    }


    class Core
    {
        /// <summary>
        /// Variable to store the parent ID for sub-organisation.
        /// </summary>
        uint parId;

        /// <summary>
        /// Percentage of administrator salary in relation to the total salary of all workers in the department.
        /// </summary>
        private int percentAdminSalary = 15;

        /// <summary>
        /// Random number generator for various operations.
        /// </summary>
        private Random rnd = new Random();

        /// <summary>
        /// Collection to store organisations.
        /// </summary>
        public static ObservableCollection<Organisation> org;

        /// <summary>
        /// Collection to store sub-departments.
        /// </summary>
        private ObservableCollection<Organisation> subDepartment;

        /// <summary>
        /// List to store department numbers without child departments.
        /// </summary>
        private List<int> deptsWithoutChilds;

        /// <summary>
        /// List to store department numbers with child departments.
        /// </summary>
        private List<int> deptsWithChilds;

        /// <summary>
        /// Creates the main organization.
        /// </summary>
        /// <param name="amount">Number of root departments.</param>
        /// <returns>ObservableCollection of Organisation</returns>
        public ObservableCollection<Organisation> CreateOrg(int amount)
        {
            org = new ObservableCollection<Organisation>();
            org.Add(new Organisation("MainOrg"));
            CreateSubOrgs(amount);
            AddEmpToOrg(500);       // Add 500 employees
            deptsWithoutChilds = GetSubDeptsWODescendants();
            deptsWithChilds = GetDeptsWithDescendants(deptsWithoutChilds);
            GetAdminSalary(deptsWithoutChilds);
            GetAllSalary(deptsWithChilds);
            return org;
        }

        /// <summary>
        /// Creates root departments.
        /// </summary>
        /// <param name="amount">Amount of sub-departments.</param>
        private void CreateSubOrgs(int amount)
        {
            ++parId;
            for (int i = 0; i < amount; i++)
            {
                org.Add(new Organisation() { ParId = parId });
            }
            CreateSubDepts(amount);
            parId = 0;
        }

        /// <summary>
        /// Creates sub-departments.
        /// </summary>
        /// <param name="amount">Number of sub-departments to create.</param>
        private void CreateSubDepts(int amount)
        {
            for (int i = 0; i < amount * 4; i++)
            {
                org.Add(new Organisation() { ParId = (uint)rnd.Next(2, amount + 2) });
            }
        }

        /// <summary>
        /// Adds employees to the organization and calculates their salary (excluding administrator's salary).
        /// </summary>
        /// <param name="empAmount">The number of employees to be added.</param>
        private void AddEmpToOrg(int empAmount)
        {
            // Add CEO as the first employee in the organization
            org[0].Employees.Add(new CEO());

            int orgNumb;

            // Loop to add the specified number of employees
            for (int i = 0; i < empAmount; i++)
            {
                switch (rnd.Next(4))
                {
                    case 0: // There is only 1 administrator allowed in each sub-department
                        orgNumb = rnd.Next(1, org.Count);

                        // Check if the sub-department already has an administrator
                        if (!CheckAdminInOrg(org[orgNumb].Employees))
                        {
                            // Add a new administrator and set their ID
                            org[orgNumb].Employees.Add(new Administrator((uint)orgNumb + 1));
                            org[orgNumb].AdministratorId = (uint)org[orgNumb].Employees.Count - 1;
                        }
                        break;
                    case 1:
                        orgNumb = rnd.Next(1, org.Count);

                        // Add a new manager and update the sub-department's salary
                        org[orgNumb].Employees.Add(new Manager((uint)orgNumb));
                        foreach (var emp in org[orgNumb].Employees)
                        {
                            if (emp is Manager)
                            {
                                org[orgNumb].SalaryAmount += emp.Salary;
                                break;
                            }
                        }
                        break;
                    case 2:
                        orgNumb = rnd.Next(1, org.Count);

                        // Add a new staff member and update the sub-department's salary
                        org[orgNumb].Employees.Add(new Staff((uint)orgNumb + 1));
                        foreach (var emp in org[orgNumb].Employees)
                        {
                            if (emp is Staff)
                            {
                                org[orgNumb].SalaryAmount += emp.Salary;
                                break;
                            }
                        }
                        break;
                    case 3:
                        orgNumb = rnd.Next(1, org.Count);

                        // Add a new intern and update the sub-department's salary
                        org[orgNumb].Employees.Add(new Intern((uint)orgNumb + 1));
                        foreach (var emp in org[orgNumb].Employees)
                        {
                            if (emp is Intern)
                            {
                                org[orgNumb].SalaryAmount += emp.Salary;
                                break;
                            }
                        }
                        break;
                }
            }
        }

        /// <summary>
        /// Calculates the salary of administrators and the entire department in the list of departments without child departments.
        /// </summary>
        /// <param name="depNumbs">List of department numbers without child departments.</param>
        private void GetAdminSalary(List<int> depNumbs)
        {
            int AdminID;

            int estimatedSalary;

            for (int i = 0; i < depNumbs.Count; i++)            
            {
                AdminID = (int)org[depNumbs[i]].AdministratorId;

                estimatedSalary = (int)org[depNumbs[i]].SalaryAmount / 100 * percentAdminSalary;
                
                if (estimatedSalary > org[depNumbs[i]].Employees[AdminID].Salary)
                {
                    org[depNumbs[i]].Employees[AdminID].Salary = (uint)estimatedSalary;
                }
                
                org[depNumbs[i]].SalaryAmount = org[depNumbs[i]].Employees[AdminID].Salary + org[depNumbs[i]].SalaryAmount;  
                
                org[depNumbs[i]].SalaryFlag = true;
            }
        }


        /// <summary>
        /// Calculates the salary of the administrator and the entire department.
        /// </summary>
        /// <param name="currDept">Number of the current department.</param>
        /// <param name="subDepts">List of sub-departments of the current department.</param>
        private void GetAdminSalary(int currDept, List<int> subDepts)
        {
            int AdminID;
            int estimatedSalary;
            int estimatedSalaryAllSubDepts = 0;

            AdminID = (int)org[currDept].AdministratorId;

            for (int i = 0; i < subDepts.Count; i++)
            {
                estimatedSalaryAllSubDepts += (int)org[subDepts[i]].SalaryAmount;
            }

            estimatedSalaryAllSubDepts += (int)org[currDept].SalaryAmount;         

            estimatedSalary = estimatedSalaryAllSubDepts / 100 * percentAdminSalary;


            if (estimatedSalary > org[currDept].Employees[AdminID].Salary)
            {
                org[currDept].Employees[AdminID].Salary = (uint)estimatedSalary;
            }
            org[currDept].SalaryAmount = org[currDept].Employees[AdminID].Salary + org[currDept].SalaryAmount;      

            org[currDept].SalaryFlag = true;              
        }

        /// <summary>
        /// Calculates the salary of all sub-departments and departments.
        /// </summary>
        /// <param name="depNumbs">List of department numbers with child sub-departments.</param>
        private void GetAllSalary(List<int> depNumbs)
        {
            List<int> subDepts;

            do
            {
                for (int i = 0; i < depNumbs.Count; i++)
                {
                    subDepts = GetSubDepts(depNumbs[i]);           

                    for (int j = 0; j < subDepts.Count; j++)
                    {
                        if (org[subDepts[j]].SalaryFlag)
                        {
                            GetAdminSalary(depNumbs[i], subDepts);
                        }
                    }
                }
            } while (!CheckSalaryFlag(depNumbs));
        }

        /// <summary>
        /// Checks if the salary is calculated for all departments.
        /// </summary>
        /// <returns>True if the salary is calculated for all departments, otherwise false.</returns>
        private bool CheckSalaryFlag(List<int> deptsId)
        {
            foreach (var depts in deptsId)
            {
                if (!org[depts].SalaryFlag)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Recalculates the salary after an employee is deleted.
        /// </summary>
        /// <param name="dep">Department index to recalculate.</param>
        /// <param name="empIndex">Index of the employee in the department to delete.</param>
        public void RecalculateSalary(uint dep, int empIndex)
        {
            org[(int)dep].Employees.RemoveAt(empIndex);

            ResetSalary();

            GetAdminSalary(deptsWithoutChilds);
            GetAllSalary(deptsWithChilds);
        }

        /// <summary>
        /// Resets the salary-related properties of all employees in the organization to their original values.
        /// This includes updating salary flags, resetting salary amounts, and setting individual employee salaries
        /// based on their respective roles (Administrator, Manager, Staff, Intern).
        /// </summary>
        private void ResetSalary()
        {
            for (int i = 1; i < org.Count; i++)
            {
                // Reset salary-related properties
                org[i].SalaryFlag = false;
                org[i].SalaryAmount = 0;

                for (int j = 0; j < org[i].Employees.Count; j++)
                {
                    if (org[i].Employees[j] is Administrator)
                    {
                        org[i].Employees[j].Salary = new Administrator().Salary;
                    }
                    else if (org[i].Employees[j] is Manager)
                    {
                        org[i].Employees[j].Salary = new Manager().Salary;
                        org[i].SalaryAmount += org[i].Employees[j].Salary;
                    }
                    else if (org[i].Employees[j] is Staff)
                    {
                        org[i].Employees[j].Salary = new Staff().Salary;
                        org[i].SalaryAmount += org[i].Employees[j].Salary;
                    }
                    else 
                    {
                        org[i].Employees[j].Salary = new Intern().Salary;
                        org[i].SalaryAmount += org[i].Employees[j].Salary;
                    }
                }
            }
        }

        /// <summary>
        /// Gets the numbers of sub-departments without descendants.
        /// </summary>
        /// <returns>List of department numbers without child sub-departments.</returns>
        private List<int> GetSubDeptsWODescendants()
        {
            bool inDep = false;

            List<int> DeptsWOChilds = new List<int>();

            for (int i = 0; i <= org.Count; i++)        
            {
                for (int j = 0; j < org.Count; j++)     
                {
                    if (org[j].ParId == i)
                    {
                        inDep = true;
                        j = org.Count;                  
                    }
                }

                if (!inDep)
                {
                    DeptsWOChilds.Add(i - 1);       
                }

                inDep = false;
            }

            return DeptsWOChilds;
        }

        /// <summary>
        /// Gets the numbers of departments with descendants (excluding ID0).
        /// </summary>
        /// <param name="deptsWODescendants">List of department numbers without child sub-departments.</param>
        /// <returns>List of department numbers with child sub-departments.</returns>
        private List<int> GetDeptsWithDescendants(List<int> deptsWODescendants)
        {
            List<int> deptsWithChilds = new List<int>();

            for (int i = 1; i < org.Count; i++)
            {
                deptsWithChilds.Add(i);
            }

            foreach (int dep in deptsWODescendants)
            {
                deptsWithChilds.Remove(dep);
            }

            return deptsWithChilds;
        }

        /// <summary>
        /// Gets the list of sub-departments of the selected department.
        /// </summary>
        /// <param name="dep">Department ID.</param>
        /// <returns>List of sub-department numbers.</returns>
        private List<int> GetSubDepts(int dep)
        {
            List<int> subDepts = new List<int>();

            for (int i = 0; i < org.Count; i++)
            {
                if (org[i].ParId - 1 == dep)
                {
                    subDepts.Add((int)org[i].Id - 1);
                }
            }

            return subDepts;
        }

        /// <summary>
        /// Gets the list of departments sorted by parent ID.
        /// </summary>
        /// <param name="id">Parent ID to filter sub-departments.</param>
        /// <returns>ObservableCollection of sub-departments.</returns>
        public ObservableCollection<Organisation> GetSubDepts(uint id)
        {
            subDepartment = new ObservableCollection<Organisation>();

            for (int i = 0; i < org.Count; i++)
            {
                if (org[i].ParId == id)
                {
                    subDepartment.Add(org[i]);
                }
            }
            return subDepartment;
        }

        /// <summary>
        /// Checks if an administrator exists in the given list of employees.
        /// </summary>
        /// <param name="emp">List of employees to check.</param>
        /// <returns>True if an administrator is found, otherwise false.</returns>
        private bool CheckAdminInOrg(ObservableCollection<Employee> emp)
        {
            for (int i = 0; i < emp.Count; i++)
            {
                if (emp[i] is Administrator)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Clears all data in the organization, including employee and department counts,
        /// and clears both the main organization and sub-department collections.
        /// </summary>
        public void ClearData()
        {
            Employee.count = 0;
            Organisation.count = 0;

            org.Clear();
            subDepartment.Clear();
        }
    }
}
