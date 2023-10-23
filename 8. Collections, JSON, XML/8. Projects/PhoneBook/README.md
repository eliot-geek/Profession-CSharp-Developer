# Task 2: Phone Book

## What to Do
The user is prompted to iteratively enter phone numbers and the full names of their owners into the program.  
During input, the information is stored in a Dictionary where the phone number is the key and the owner's full name is the value.  
Thus, one owner may have multiple phone numbers.  
An empty input line signifies that the user has finished entering phone numbers.  
Afterward, the program offers to find the owner based on a given phone number. The user enters a phone number, and the program displays the owner's full name.  
If the owner is not registered under that phone number, the program outputs a corresponding message.

## Hint
To find a value in the Dictionary, use [TryGetValue](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2.trygetvalue?view=net-5.0).

## What Is Evaluated
The program is divided into logical methods, and a Dictionary is used to store the phone book entries.
