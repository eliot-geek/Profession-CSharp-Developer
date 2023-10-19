## **Application for determining even or odd numbers**

Write an application that determines whether a number is even or odd.  

The algorithm for the application is as follows:  
On the screen, the program prompts the user to enter an integer using the Console.WriteLine statement.  
The Console.ReadLine statement is used to read the entered number.  
The int.Parse method is used to convert the number to an integer variable.  
Using the modulus operator (%), the application determines whether the number is even or odd.  
Depending on the result of the previous step, the application displays text indicating whether the number is even or odd.

## Recommendation:

In C#, the modulus operator is represented by the % symbol.  
Therefore, to check if a number N is even, the logical expression N % 2 == 0 will be true.  
If this expression is false, the number is odd.
