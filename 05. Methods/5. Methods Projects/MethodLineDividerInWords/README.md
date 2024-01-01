# **Task 1: Method for Splitting a String into Words**

## **Description**

In a console application, the user inputs a long sentence. Each word in this sentence is separated by a space. Create a method that takes a string variable as input and returns an array of words. After calling this method, the program invokes a second method that prints each word on a separate line. The method should have the following signature: `static string[] SplitText(string text)`, where `text` is the string to be split.

## **Tips and Recommendations**

- You can implement the word-splitting algorithm manually using a loop, or you can use the `string.Split(' ')` method.
- More information about it can be found in the [Microsoft documentation](https://docs.microsoft.com/en-us/dotnet/api/system.string.split).
- Use CamelCase for method names, where each subsequent word starts with an uppercase letter. For example, a method named `GetPositiveRandomInt` returns a positive random integer.
- Follow the same naming convention for your methods.
- Avoid global variables in the program. All data should be passed between methods through parameters and return values.

## Evaluation Criteria

The program should include two additional methods, apart from the main method, which are called within the body of the main method.  
The names of the methods should reflect their functionality: splitting or displaying data.
