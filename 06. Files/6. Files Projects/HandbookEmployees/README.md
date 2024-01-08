# Employee Directory Management

## Description

Create an employee directory for a hypothetical company. Develop a program that adds records of new employees to a file. The file should contain the following information for each employee:

- ID
- Date and time of record creation
- Full name
- Age
- Height
- Date of birth
- Place of birth

Data should be entered from the keyboard. After entering the data:

- If the file doesn't exist, create it.
- If the file exists, append the employee's data to the end of the file.

Upon running the program, you should have the option to:

- Enter "1" to display the data on the screen.
- Enter "2" to input data and add a new record to the end of the file.

The file should have the following structure:

```
  1#20.12.2021 00:12#Ivanov Ivan Ivanovich#25#176#05.05.1992#Moscow
  2#15.12.2021 03:12#Alexeev Alexey Ivanovich#24#176#05.11.1980#Tomsk

```


## Tips and Recommendations

- Note that "#" is used as a separator in the file. When reading the file, remove the "#" character and split the string into an array of elements using the `String.Split` method.
- Divide the program into methods (reading and writing).
- Add new records to the end of the file.
- Check if the file exists.

## Frequently Asked Questions

How do I choose the right data type for my variables?

Follow the traditional approach: when creating a new variable, first think about the type of data it will store. Is it textual information, characters? Use `string`. Is it a number? Use numerical data types like `int` or `double`. Be careful: if everything in your code has the same data type, you may have done something wrong. It's normal to use data types that match the data being stored. More data types may be introduced later, but the approach remains the same: before creating a variable, think about what information it will hold and choose the data type that matches the stored data. For more information, refer to the "File Operations: File Class and FileInfo Class" and "Data Types" articles.

## What's Evaluated

- The structure of the file after adding an employee is consistent.
- Each method performs a single task.
- The employee record is correctly displayed on the console.
- The file is correctly closed after writing and reading.

