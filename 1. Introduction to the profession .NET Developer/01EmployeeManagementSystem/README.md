# **Task**

This program is designed to create a library capable of generating and managing a database of employees. The main class, named "Program," serves as the core state unit of the application. The program encompasses the following functionalities:

1. Creating a database of employees.
2. Printing to the console the information of all employees in the database.
3. Dismissing employees based on name or salary.

The program comprises two additional classes: `Worker` and `Repository`.

## Worker Class

The `Worker` class describes the model of an employee with the following fields:

- Name
- Surname
- Age
- Salary

## Repository Class

The `Repository` class is responsible for organizing data storage and generation. It performs the following tasks:

- Generates databases of names, surnames, and pseudorandom numbers.
- Populates a database of employees with randomly generated values.
- Provides methods for adding new employees to the database.
- Selects a random name from the databases.
- Generates a random age and salary.
- Outputs the database to the console.
- Dismisses employees with a salary greater than a specified value or with a given name.

### Methods in the Repository Class:

- `AddEmployee`: Adds a new employee to the database.
- `SelectRandomName`: Selects a random name from the databases.
- `GenerateRandomAge`: Generates a random age.
- `GenerateRandomSalary`: Generates a random salary.
- `PrintEmployeeDatabase`: Outputs the database to the console.
- `DismissEmployeesBySalary`: Dismisses employees with a salary greater than a specified value.
- `DismissEmployeesByName`: Dismisses employees with a given name.

## **Homework**

### **Difficulty Level: Simple**

Modify the program to ensure that the number of employees in the department does not exceed 20 before the first round of layoffs.

### **Difficulty Level: Intermediate**

Create a department with 40 employees and perform multiple rounds of layoffs until no more than 30 employees are left in the department.

### **Difficulty Level: Advanced**

Create a department with 50 employees and implement a filter to identify and dismiss all employees with a salary greater than $30,000.

### **Instructions**

- **Simple Difficulty:**
  - Update the program logic to limit the number of employees in the department to 20 before the first round of layoffs.
  
- **Intermediate Difficulty:**
  - Initialize a department with 40 employees.
  - Implement a mechanism for multiple rounds of layoffs until no more than 30 employees remain in the department.

- **Advanced Difficulty:**
  - Create a department with 50 employees.
  - Implement a filter to identify employees with a salary greater than $30,000.
  - Dismiss all employees matching the filter criteria.
