# **Task**
This program is for creating a library that can generate and manage a database of employees.  
It contains a main class called "Program" which serves as the main state unit of the application. The program has the following functionalities:

1. Creating a database of employees
2. Printing to the console the information of all employees in the database
3. Dismissing employees based on name or salary

The program consists of two other classes: Worker and Repository.  
The Worker class describes the model of an employee with fields for name, surname, age, and salary.  
The Repository class is responsible for organizing data storage and generation.  
It generates databases of names, surnames, and pseudorandom numbers, and populates a database of employees with randomly generated values.  
The Repository class also has methods for adding new employees to the database, selecting a random name from the databases, generating a random age and salary, and outputting the database to the console.  
It also has methods for dismissing employees with a salary greater than a specified value or with a given name.

## **Homework**

**Difficulty Level: Simple**  
Modify the program to ensure that the number of employees in the department doesnot exceed 20 before the first round of layoffs.  
**Difficulty Level: Intermediate**  
Create a department with 40 employees and perform multiple rounds of layoffs until no more than 30 employees are left in the department.  
**Difficulty Level: Advanced**  
Create a department with 50 employees and implement a filter to identify and dismiss all employees with a salary greater than $30,000.  
