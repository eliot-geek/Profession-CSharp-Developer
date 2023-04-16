Finding the smallest element in a sequence

What needs to be done:

Find the smallest element in a sequence entered by the user. The detailed algorithm of the program is as follows:

The user enters the length of the sequence.
Then the user enters integers one by one (both positive and negative), separated by the Enter key.
Each entered number is compared with the value of the variable responsible for the minimum element. If the entered number is less than the current minimum, the value of the variable should be updated.

Recommendation:

To correctly organize the search for the smallest number, during the initialization stage of the variable responsible for the minimum element, choose int.MaxValue as the initial value of the minimum number. Then any of the numbers that the user enters will be smaller than this value