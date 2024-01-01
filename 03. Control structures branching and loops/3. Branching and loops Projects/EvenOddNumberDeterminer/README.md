# Application for Determining Even or Odd Numbers

## Description

This application determines whether a given number is even or odd. The algorithm for the application is outlined as follows:

1. **User Input Prompt:** The program prompts the user to enter an integer using the `Console.WriteLine` statement.

2. **Reading User Input:** The `Console.ReadLine` statement is used to read the entered number as a string.

3. **Conversion to Integer:** The `int.Parse` method is employed to convert the entered string to an integer variable.

4. **Checking Even or Odd:** Using the modulus operator (`%`), the application determines whether the number is even or odd.
   - If the expression `N % 2 == 0` is true, the number is even.
   - If the expression is false, the number is odd.

5. **Displaying Result:** Depending on the result of the previous step, the application displays text indicating whether the number is even or odd.

## Recommendation

- In C#, the modulus operator is represented by the `%` symbol.
- Utilize the logical expression `N % 2 == 0` to check if a number `N` is even.
- Provide clear and informative messages to the user regarding the nature of the entered number.
