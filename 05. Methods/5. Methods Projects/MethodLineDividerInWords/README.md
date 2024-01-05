# String Splitting Method in a Console Application

## Description

In this console application, the user provides input in the form of a long sentence where each word is separated by a space. The task is to create a method that takes a string variable as input and returns an array of words. Subsequently, another method is invoked to print each word on a separate line. The method to split the string should have the following signature: `static string[] SplitText(string text)`, where `text` is the string to be split.

## Tips and Recommendations

- The word-splitting algorithm can be implemented manually using a loop or by utilizing the `string.Split(' ')` method.
- Refer to the [Microsoft documentation](https://docs.microsoft.com/en-us/dotnet/api/system.string.split) for more information on string splitting methods.
- Adopt CamelCase for method names, where each subsequent word starts with an uppercase letter.
- For example, a method named `GetPositiveRandomInt` returns a positive random integer.
- All data exchange between methods should occur through parameters and return values; avoid the use of global variables.

## Evaluation Criteria

The program structure should consist of two additional methods, besides the main method, and these methods should be called within the body of the main method.  
The names of these methods should clearly reflect their functionality, whether it's splitting or displaying data.
