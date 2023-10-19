# Task 3: Checking for a Prime Number

## What Needs to be Done
This task is one of the most common and popular ones. A prime number is a number that is divisible only by itself and one. There are many algorithms for finding prime numbers. Implement one of the simplest ones. Check an integer entered from the keyboard for the prime property. To solidify your knowledge, implement this task using a while loop.

## **Here's what you should do:**

1. The user starts by entering an integer.
2. Then, in a loop, you need to go through all the numbers from 1 to N - 1.
3. During each iteration of the loop, divide the input number N by the current number with the remainder.
4. If the remainder of the division is equal to 0, it means the program has found a divisor for this number, so it cannot be considered a prime number anymore.
5. If the remainder of the division is 0, assign the value true to a boolean variable declared outside the loop.
6. After exiting the loop, if the variable's value remains false, it means the number is prime. If the variable's value becomes true, it means a divisor was found, so the number cannot be considered prime.

## **Tips and Recommendations:**
- Look at the modulus operator.
- To check for prime numbers, use known prime numbers like 3, 7, 37, 79, 173.

## What is Being Assessed
- The program displays whether the number is prime or not.
- The program does not hang.
