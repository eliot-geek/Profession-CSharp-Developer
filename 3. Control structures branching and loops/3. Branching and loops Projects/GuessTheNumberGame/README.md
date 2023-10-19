# **Task 5: Guess the Number Game**

## **What Needs to be Done**
Develop a program based on the following algorithm:

1. The user enters the maximum integer of the range.
2. Based on the range of integers (from 0 to the value entered by the user), the program generates a random integer within the range.
3. The user is asked to guess the randomly generated number. The user enters their guesses in the application's console.
4. If the user's guess is less than the randomly generated number, the program informs the user of this.
5. If the guess is greater, the program also informs the user that the number is greater.
6. The program continues until the user correctly guesses the number.
7. If the user gets tired of playing and wants to quit, they can input an empty string and press Enter. In this case, the program terminates, displaying the randomly generated number.

## **Tips and Recommendations**
To organize infinite input of numbers and allow the user to input as many numbers as they want, use a while or do-while loop with a condition such as (1 == 1) or simply (true).
Use the `break` statement to exit the infinite loop.
