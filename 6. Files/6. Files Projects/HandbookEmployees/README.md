Task 

The aim of this practical work is to learn how to work with the file system by being able to read data from a file and write data to it.

To accomplish this, create a directory called "Employees" and develop a program for a hypothetical company that adds records of new employees to a file. The file should contain the following data:

ID

Date and time the record was added

Full name

Age

Height

Date of birth

Place of birth


Data should be entered via keyboard input. After data input, the program should:

Create the file if it doesn't exist
Append the new employee's data to the end of the file if it already exists

Upon running the program, the user should be prompted to:

Enter 1 to display the data on the screen
Enter 2 to fill out the data and add a new record to the end of the file.

The file should have the following structure:

1#20.12.2021 00:12#Ivanov Ivan Ivanovich#25#176#05.05.1992#Moscow
2#15.12.2021 03:12#Alexeev Alexey Ivanovich#24#176#05.11.1980#Tomsk
...

Tips and recommendations:

Note that the # symbol is used as a delimiter in the string. When reading the file, it's necessary to remove the # symbol. Use the String.Split method to split the string into an array of elements.
Divide the program into methods (reading, writing).
Add new records to the end of the file.
Check if the file exists or not.