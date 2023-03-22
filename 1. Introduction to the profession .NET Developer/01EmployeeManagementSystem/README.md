This program is for creating a library that can generate and manage a database of employees. It contains a main class called "Program" which serves as the main state unit of the application. The program has the following functionalities:

Creating a database of employees
Printing to the console the information of all employees in the database
Dismissing employees based on name or salary
The program consists of two other classes: Worker and Repository. The Worker class describes the model of an employee with fields for name, surname, age, and salary. The Repository class is responsible for organizing data storage and generation. It generates databases of names, surnames, and pseudorandom numbers, and populates a database of employees with randomly generated values.

The Repository class also has methods for adding new employees to the database, selecting a random name from the databases, generating a random age and salary, and outputting the database to the console. It also has methods for dismissing employees with a salary greater than a specified value or with a given name.


HOMEWORK


// Difficulty level: Simple
// Task 1. Redo the program so that before the first wave of layoffs in the department there were no more than 20 employees


// Difficulty level: Medium difficulty
// * Task 2. Create a department of 40 employees and implement several layoffs, according to the results of which no more than 30 employees should remain in the department


// Difficulty level: Difficult
// ** Task 3. Create a department of 50 employees and implement the dismissal of employees whose salary exceeds 30,000 $
