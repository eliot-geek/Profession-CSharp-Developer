Task 1. 
The method of dividing a line into words

What has to be done

The user enters a long sentence in a console application. Each word in that sentence is separated by a space. Create a method that takes a string variable as an input parameter and an array of words as a return value. After calling this method, the program calls a second method that outputs each word on a separate line. The method should look like this: static string[] SplitText(string text), where text is the string you want to split.


Tips and tricks

To implement this program, you can write a word splitting algorithm yourself using a loop. You can also use the method string.Split(' ');. See the Microsoft documentation page for more information about it.
Use CamelCase for method names, where each next word starts with a capital letter. For example, a method named GetPositiveRandomInt returns a positive random integer. The same principle should be used to name your methods.
There must not be any global variables in the program. All data between methods must be passed through parameters and return values.

What is evaluated

In addition to the main method main, the program contains two other methods, which are called in the body of the method main. 
The names of the methods correspond to what they do: divide or output data.