Checking for Prime Numbers

In this task, you are required to implement one of the easiest algorithms to check for prime numbers. A prime number is a number that is divisible only by 1 and itself. The task is to take an integer input from the user and check if it is a prime number or not using a while loop.

To start with, the user inputs an integer number. Then, using a loop, all numbers from 1 to N-1 are checked. At each iteration of the loop, the input number N is divided by the current number with a remainder. If the remainder is 0, the program has found a divisor of the number, and therefore the number cannot be a prime number.

If the remainder is not 0, the loop continues until all numbers have been checked. If the loop completes without finding a divisor, then the number is a prime number.

To implement this, you will need to declare a boolean variable outside of the loop, which will be set to false. If a divisor is found, this variable will be set to true. After the loop, if the variable is still false, the number is a prime number. If the variable is true, then the number is not a prime number.

For reference, you can use simple prime numbers such as 3, 7, 37, 79, and 173 to check for prime numbers.