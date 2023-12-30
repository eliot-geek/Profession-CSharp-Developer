# **21 Game Card Sum Calculator**

## **Description:**

You are required to write a program that calculates the total value of cards in the game "21". In this game, each card has a specific "value". The program should follow the following algorithm:  

1. The program should greet the user and ask how many cards they have in their hand.
2. The user should input a whole number.
3. This number is then converted into a counter for the loop.
4. Using a for loop, the user will be asked to enter the value of each card. For cards with a numeric value, the user should enter only the digit.
5. For "face" cards, the user should enter the designated letter:
  - Jack = J
  - Queen = Q
  - King = K
  - Ace = T

Within the loop, the program should use a switch statement to add the "value" of each card to a total sum variable, which is declared before the body of the main loop.
For numeric cards, their "value" is equal to the value inputted by the user. For face cards, their "value" is equal to 10.
After all cards have been entered, the program should display the total sum of the cards on the screen.

## **Recommendation:**

To add a value to a variable, you can use the following shorthand: `sum = sum + 10`;  
This will add 10 to the current value of the variable "sum". This will increase the value of the variable, rather than overwriting it.

Before converting the input string to a number, it's important to check if the user has entered a "face" card.  
If they have, add 10 to the sum. Otherwise, you can use the int.Parse() method.
