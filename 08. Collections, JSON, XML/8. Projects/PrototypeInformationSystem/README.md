# Organizational Structure Information System

## Instructions
Create a prototype of an information system that facilitates working with the organizational structure.  
This structure includes departments and employees.  
Each department can have a maximum of 1,000,000 employees. 

Each department should have the following fields:
- Name
- Creation Date
- The number of employees (feel free to add any other desired fields)

Each employee should have the following fields:
- Last Name
- First Name
- Age
- Department to which they belong
- Unique Identifier
- Compensation
- Number of Projects Assigned

In this information system, you should implement the following features:

1. Import and export all information to XML and JSON.
2. Add, remove, and edit employees and departments.
3. Implement the ability to order employees within a department based on various fields such as age and compensation.

## Task Example

You can order employees within a department based on a single field, like age:

```
  №     Name       Surname         Age           Department     Compensation     Number of Projects
  1   Name_1     Surname_1          23         Department_1            10000                      3 
  2   Name_2     Surname_2          21         Department_2            20000                      3 
  3   Name_3     Surname_3          22         Department_1            20000                      3 
  4   Name_4     Surname_4          24         Department_1            10000                      3 
  5   Name_5     Surname_5          22         Department_2            20000                      3 
  6   Name_6     Surname_6          22         Department_1            10000                      3 
  7   Name_7     Surname_7          23         Department_1            20000                      3 
  8   Name_8     Surname_8          23         Department_1            30000                      3 
  9   Name_9     Surname_9          21         Department_1            30000                      3 
 10  Name_10    Surname_10          21         Department_2            10000                      3 
 

 Ordering by a single field, age
 
  №     Name       Surname         Age           Department     Compensation     Number of Projects
  2   Name_2     Surname_2          21         Department_2            20000                      3 
 10  Name_10    Surname_10          21         Department_2            10000                      3 
  9   Name_9     Surname_9          21         Department_1            30000                      3 
  3   Name_3     Surname_3          22         Department_1            20000                      3 
  5   Name_5     Surname_5          22         Department_2            20000                      3 
  6   Name_6     Surname_6          22         Department_1            10000                      3 
  1   Name_1     Surname_1          23         Department_1            10000                      3 
  8   Name_8     Surname_8          23         Department_1            30000                      3 
  7   Name_7     Surname_7          23         Department_1            20000                      3 
  4   Name_4     Surname_4          24         Department_1            10000                      3 


```
