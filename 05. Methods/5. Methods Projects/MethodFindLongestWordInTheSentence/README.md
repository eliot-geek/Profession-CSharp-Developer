# Find Words with the Maximum Number of Letters

## Description

Develop a method that takes a text as input and returns the word or words with the maximum number of letters. Words in the text may be separated by characters such as spaces, periods, or commas.

### Example

Suppose you have the following text:  
Text: "A BB VVV GGGG DDDD EE ZZZ"  

The expected answer is: "GGGG, DDDD"

## Implementation

Create a method with the following signature:  
```csharp
static string FindMaxLengthWords(string text)
```

The method should analyze the input text and return the word or words with the maximum number of letters. If there are multiple words with the same maximum length, return all of them, separated by commas.
