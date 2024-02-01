using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Windows;
using Microsoft.Win32;
using Newtonsoft.Json.Linq;

namespace HierarchyManagementSystem
{
    class Core
    {
        /// <summary>
        /// Represents the main organization with root departments.
        /// </summary>
        private ObservableCollection<Organisation> org;

        /// <summary>
        /// Represents the collection of sub-departments.
        /// </summary>
        private ObservableCollection<Organisation> subDepartment;

        /// <summary>
        /// Represents the parent ID for sub-organization.
        /// </summary>
        private uint parId;

        /// <summary>
        /// Represents the random number generator.
        /// </summary>
        private Random rnd = new Random();

        /// <summary>
        /// Represents the JSON string.
        /// </summary>
        private string json;

        /// <summary>
        /// Creates the main organization with a specified number of root departments.
        /// </summary>
        /// <param name="amount">Number of root departments.</param>
        /// <returns>Observable collection of root departments.</returns>
        public ObservableCollection<Organisation> CreateOrg(int amount)
        {
            org = new ObservableCollection<Organisation>();
            org.Add(new Organisation("MainOrg"));
            CreateSubOrgs(amount);
            AddEmpToOrg(500);
            List<int> deptsWithoutChilds = GetSubDeptsWODescendants();
            List<int> deptsWithChilds = GetDeptsWithDescendants(deptsWithoutChilds);
            GetAdminSalary(deptsWithoutChilds);
            GetAllSalary(deptsWithChilds);
            return org;
        }

        /// <summary>
        /// Creates root departments for the organization.
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
        /// Creates sub-departments for the organization.
        /// </summary>
        /// <param name="amount">Amount of sub-departments.</param>
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
        /// <param name="empAmount">Amount of employees.</param>
        private void AddEmpToOrg(int empAmount)
        {
            org[0].Employees.Add(new CEO());
            int orgNumb;

            for (int i = 0; i < empAmount; i++)
            {
                switch (rnd.Next(4))
                {
                    // There is only 1 administrator could be in one sub department
                    case 0:
                        orgNumb = rnd.Next(1, org.Count);
                        if (!CheckAdminInOrg(org[orgNumb].Employees))
                        {
                            org[orgNumb].Employees.Add(new Administrator());
                            // Get Administrator ID
                            org[orgNumb].AdministratorId = (uint)org[orgNumb].Employees.Count - 1;

                        }
                        break;
                    case 1:
                        orgNumb = rnd.Next(1, org.Count);
                        org[orgNumb].Employees.Add(new Manager());

                        // Add Manager's salary to sub department salary list
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
                        org[orgNumb].Employees.Add(new Staff());

                        // Add Staff's salary to sub department salary list
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
                        org[orgNumb].Employees.Add(new Intern());

                        // Add Intern's salary to sub department salary list
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
        /// Calculates the salary of administrators and the whole department for a list of departments without children.
        /// </summary>
        /// <param name="depNumbs">List of department numbers without descendants.</param>
        private void GetAdminSalary(List<int> depNumbs)
        {
            int AdminID;
            int estimatedSalary;

            // Get and set Administrator's salary
            for (int i = 0; i < depNumbs.Count; i++)            
            {
                AdminID = (int)org[depNumbs[i]].AdministratorId;
                estimatedSalary = (int)org[depNumbs[i]].SalaryAmount / 100 * 15;
                if (estimatedSalary > org[depNumbs[i]].Employees[AdminID].Salary)
                {
                    org[depNumbs[i]].Employees[AdminID].Salary = (uint)estimatedSalary;
                }

                // Salary of the whole department
                org[depNumbs[i]].SalaryAmount = org[depNumbs[i]].Employees[AdminID].Salary + org[depNumbs[i]].SalaryAmount;

                // Salary of current department is calculated
                org[depNumbs[i]].SalaryFlag = true;             
            }
        }

        /// <summary>
        /// Calculates the salary of the administrator and the whole department.
        /// </summary>
        /// <param name="currDept">Number of the current department.</param>
        /// <param name="subDepts">List of sub-departments for the current account.</param>
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

            // Add current department salary
            estimatedSalaryAllSubDepts += (int) org[currDept].SalaryAmount;        
            estimatedSalary = estimatedSalaryAllSubDepts / 100 * 15;


            if (estimatedSalary > org[currDept].Employees[AdminID].Salary)
            {
                org[currDept].Employees[AdminID].Salary = (uint)estimatedSalary;
            }

            // Salary of the whole department
            org[currDept].SalaryAmount = org[currDept].Employees[AdminID].Salary + org[currDept].SalaryAmount;

            // Salary of department is calculated
            org[currDept].SalaryFlag = true;              
        }

        /// <summary>
        /// Calculates the salary of all sub-departments and departments.
        /// Depts with child sub departments
        /// </summary>
        /// <param name="depNumbs">List of department numbers with child sub-departments.</param>
        private void GetAllSalary(List<int> depNumbs)  
        {
            List<int> subDepts;

            do
            {
                for (int i = 0; i < depNumbs.Count; i++)
                {
                    // Get sub departments list of selected department
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
        /// Checks if the salary in all departments is calculated.
        /// </summary>
        /// <returns>True if the salary is calculated in all departments, otherwise false.</returns>
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
        /// Gets the numbers of sub-departments without descendants.
        /// </summary>
        /// <returns>List of department numbers without child sub-departments.</returns>
        private List<int> GetSubDeptsWODescendants()
        {
            bool inDep = false;
            List<int> DeptsWOChilds = new List<int>();

            for (int i = 0; i <= org.Count; i++) // Department number
            {
                for (int j = 0; j < org.Count; j++) // Parent ID number
                {
                    if (org[j].ParId == i)
                    {
                        inDep = true;
                        j = org.Count; // Exit condition
                    }
                }

                if (!inDep)
                {
                    DeptsWOChilds.Add(i - 1); // Add sub-department without descendants to the list
                }
                inDep = false;
            }
            return DeptsWOChilds;
        }

        /// <summary>
        /// Gets the numbers of departments with descendants (except ID0).
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
                if (org[i].ParId-1 == dep)
                {
                    subDepts.Add((int)org[i].Id-1);
                }
            }
            return subDepts;
        }

        /// <summary>
        /// Gets the list of departments sorted by parent ID.
        /// </summary>
        /// <param name="id">Parent ID.</param>
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
        /// Checks if there is an administrator in the sub-department.
        /// </summary>
        /// <param name="emp">List of employees in the sub-department.</param>
        /// <returns>True if there is an administrator, false otherwise.</returns>
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
        /// Clears all data, resetting employee and organisation counters, and clearing the organisation and sub-department collections.
        /// </summary>
        public void ClearData()
        {
            Employee.count = 0;
            Organisation.count = 0;
            org.Clear();
            subDepartment.Clear();
        }

        /// <summary>
        /// Serializes the data and saves it to a file in JSON format.
        /// </summary>
        public void SaveData()
        {
            json = JsonConvert.SerializeObject(org);
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "data";
            save.DefaultExt = ".json";
            save.Filter = "JSON file (.json)|*.json";

            if (save.ShowDialog() == true)
            {
                string filename = save.FileName;
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    sw.WriteLine(json);
                }
            }
            MessageBox.Show("Data successfully saved", "Save data", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        /// <summary>
        /// Loads the data from a file and returns the deserialized ObservableCollection of Organisation.
        /// </summary>
        /// <returns>ObservableCollection of Organisation.</returns>
        public ObservableCollection<Organisation> LoadData()
        {
            OpenFileDialog load = new OpenFileDialog();
            load.FileName = "data";
            load.DefaultExt = ".json";
            load.Filter = "JSON file (.json)|*.json";

            if (load.ShowDialog() == true)
            {
                string filename = load.FileName;

                using (StreamReader sr = new StreamReader(filename))
                {
                    json = sr.ReadToEnd();
                }
                JsonConverter[] converters = { new EmployeeConverter() };
                org = JsonConvert.DeserializeObject<ObservableCollection<Organisation>>(json, new JsonSerializerSettings() { Converters = converters });
            }

            MessageBox.Show("Data successfully loaded", "Load data", MessageBoxButton.OK, MessageBoxImage.Information);
            return org;
        }

        /// <summary>
        /// Custom JSON converter for deserializing Employee objects based on their Position property.
        /// </summary>
        public class EmployeeConverter : JsonConverter
        {
            /// <summary>
            /// Determines whether this converter can convert the specified type.
            /// </summary>
            /// <param name="objectType">The type to convert.</param>
            /// <returns>True if the type is Employee; otherwise, false.</returns>
            public override bool CanConvert(Type objectType)
            {
                return (objectType == typeof(Employee));
            }

            /// <summary>
            /// Reads JSON data and converts it into an Employee object based on the Position property.
            /// </summary>
            /// <param name="reader">The JsonReader to read from.</param>
            /// <param name="objectType">The type of the object to convert.</param>
            /// <param name="existingValue">The existing value of the object being read.</param>
            /// <param name="serializer">The calling serializer.</param>
            /// <returns>The deserialized Employee object.</returns>
            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                JObject jo = JObject.Load(reader);

                if (jo["Position"].Value<string>() == "CEO")
                    return jo.ToObject<CEO>(serializer);

                if (jo["Position"].Value<string>() == "Administrator")
                    return jo.ToObject<Administrator>(serializer);

                if (jo["Position"].Value<string>() == "Manager")
                    return jo.ToObject<Manager>(serializer);

                if (jo["Position"].Value<string>() == "Staff")
                    return jo.ToObject<Staff>(serializer);

                if (jo["Position"].Value<string>() == "Intern")
                    return jo.ToObject<Intern>(serializer);

                return null;
            }

            /// <summary>
            /// Gets a value indicating whether this JsonConverter can write JSON.
            /// </summary>
            public override bool CanWrite
            {
                get { return false; }
            }

            /// <summary>
            /// Writes JSON. This method is not implemented and will throw an exception if called.
            /// </summary>
            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                throw new NotImplementedException();
            }
        }
    }
}
