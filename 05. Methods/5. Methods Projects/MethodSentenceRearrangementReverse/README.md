# Task 2: Rearranging Words in a Sentence

The user inputs a long sentence into the program, with each word separated by a space. After input, the user presses the Enter key. Your objective is to create two methods:

1. The first method divides the words in the sentence.
2. The second method swaps the positions of these words in reverse order.

Note that one method is called within another, where the `main` method calls a method with the signature `ReverseWords(string inputPhrase)`. Inside this method, the word-splitting method is called. The word-splitting method should look like this: `static string Reverse(string text)`, where `text` is the sentence in which the words need to be rearranged.

## Tips and Recommendations

- To concatenate strings, you can use string concatenation. An expression like `ResultString += NewString + " "` appends a new string from the variable `NewString`, along with a space, to the end of the current string represented by `ResultString`.
- To implement the algorithm of splitting a string into words, you can follow the recommendations from task 1.
- The program should not use global variables. All data between methods should be passed through parameters and return values.

## Frequently Asked Questions

### What are method parameters?

Method parameters are what we pass into a method for further processing. For example, if we want our method to calculate the area of a square, we would pass the side length of the square as a parameter. Parameters are specified within parentheses like this: `(ParameterType ParameterName)`. For example, in the context of calculating the square's area, we would have a method like `void Square(int sideLength)`. Such a method can be called as `Square(5)`, where `5` is the side length we are passing as a parameter. Learn more about parameters in the article ["Method Parameters"](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods#method-parameters).

### What is a return value?

A return value is the result of a method's work. For example, a method that calculates the square's area should return a number, which is the sought-after square's area. The value is returned using the `return` operator. Learn more about return values in the article ["Returning a Value and the `return` Statement"](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods#returning-a-value-and-the-return-statement).

## What Is Evaluated

The method for splitting the text into words is called from within the method responsible for reversing words in the sentence.
