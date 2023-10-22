# Task 4: Finding the Smallest Element in a Sequence

## What Needs to be Done
Find the smallest element in a sequence entered by the user. Here is a detailed program algorithm:

1. The user enters the length of the sequence.
2. Then, the user sequentially enters integers (both positive and negative) one by one, separating them with the Enter key.
3. Each entered number is compared with the value of the variable responsible for the minimum element. If the entered number is smaller, update the value of the variable.

## Recommendation
To correctly organize the search for the smallest number, initialize the variable responsible for the minimum element with `int.MaxValue` as its initial value. This way, any number entered by the user will be smaller than this value.

## What is Being Assessed
The program displays the smallest number from the user's sequence.
