Task 2. 

Rearrangement of words in a sentence

What to do

The user enters a long sentence into the program. Each word is separated with a space. After typing, the user presses the Enter key. Two methods need to be created:
The first separates the words in the sentence;
the second one swaps the words (in reverse order). 

Note that one method is called inside the other method, i.e. in the main method the method with signature ReversWords (string inputPhrase) is called. Inside this method, the method for splitting the input phrase into words is called. The method must look like this: static string Reverse(string text), where text is a sentence where you want to swap the words.

Tips and tricks

For string summation you can use string concatenation. An expression of the form ResultString += NewString + " " will add to the current string, which is represented by the variable ResultString, a new string from the variable NewString, as well as a space at the end of the string. 
To implement the algorithm for splitting the string into words, you can use the recommendations from task 1.
The program must not contain global variables. All data between methods must be passed through parameters and return values.

You are often asked

What are method parameters?

Method parameters are what we pass inside the method for further processing. For example, if we want our method to calculate the area of a square, we pass a parameter - the side of the square - to the method. Parameters are given in brackets in the form of (typeParameter nameVariableParameter), for example, talking about the area of a square void Square(int sideLength). This method will be called as Square(5), where 5 is the length of the side of the square we have passed inside the method as a parameter. For more details, see the article "Method Parameters".

What is the returned value?

This is the result of a method. For example, a method that calculates the area of a square must return a number. The value is returned by the operator return. For more details, see the article "Value return and operator return"

What is evaluated

The word division method is called inside the method that is directly responsible for inverting the words in a sentence.