# Checking For Duplicates

## Instructions
The user is prompted to input a number, which is then stored in a HashSet collection.  
If the entered number already exists in the collection, the user is notified that the number was previously entered.  
Conversely, if the number is not present in the collection, a confirmation message indicates that the number has been successfully saved.

## Recommendations
Utilize the [`Add`](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1.add?view=net-6.0) method to add a number to the HashSet.

## Evaluation Criteria
The program is expected to employ a HashSet as the underlying collection for managing numbers.
