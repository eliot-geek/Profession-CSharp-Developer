# Task: Calculation of Groups for Divisible Numbers

## Description

The task is to calculate and classify numbers from 1 to a given integer N into distinct groups. Numbers in each group must not be divisible by any other number in that group.  
As a result of this division, M groups were formed, where for N = 50, M = 6.

## Requirements

1. The program reads an integer N from a specified file, with N not exceeding 1,000,000,000.

2. The program has two operation modes:

   2.1. Display only the number of groups (M) in the console.

   2.2. Calculate and generate the groups, then write them to a file using specified file handling options.

3. After completing step 2.1 or 2.2, the program displays the time taken to generate the result in seconds and milliseconds.

4. For step 2.2, the program offers to archive the data. If the user agrees, it archives the generated data.

## Example

```
For N = 50:
- Group 1: 1
- Group 2: 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47
- Group 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49
- Group 4: 8 12 18 20 27 28 30 42 44 45 50
- Group 5: 16 24 36 40
- Group 6: 32 48

M = 6

===================

For N = 10:
- Group 1: 1
- Group 2: 2 7 9
- Group 3: 3 4 10
- Group 4: 5 6 8

M = 4

```
## Note

The task requires proper documentation of the code, including comments and XML documentation. You should create custom methods for improved code structure and maintainability.
