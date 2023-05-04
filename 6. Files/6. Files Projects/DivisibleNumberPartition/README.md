Task

Having written all numbers from 1 to N on the board, where N is 50, the teacher divided the numbers into several groups in such a way that if one number is divisible by another, then these numbers belong to different groups. As a result of this division, M groups were formed, where for N=50, M=6.

N = 50

The groups are as follows:

Group 1: 1
Group 2: 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47
Group 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49
Group 4: 8 12 18 20 27 28 30 42 44 45 50
Group 5: 16 24 36 40
Group 6: 32 48

M = 6

===================

For N = 10, the groups are as follows:

Group 1: 1
Group 2: 2 7 9
Group 3: 3 4 10
Group 4: 5 6 8

M = 4

Adding the following capabilities to it:

1. The program reads from a file (the path to which can be specified) some N, for which the number of groups needs to be calculated. The program works with numbers N not exceeding 1_000_000_000.

2. It has two operation modes:

2.1. The first - only the number of groups, i.e., the value of M, is displayed in the console.

2.2. The second - the program receives the filled groups and writes them to a file using one of the file handling options.

3. After performing steps 2.1 or 2.2, the console displays the time taken to generate the result in seconds and milliseconds.

4. After completing step 2.2, the program offers to archive the data, and if the user agrees, it does so.

When completing the current task, it is necessary to document the code, both with comments and XML documentation. It is mandatory to create several custom methods.
