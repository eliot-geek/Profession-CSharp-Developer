# **Task (The data should be entered by the user via the keyboard)**
**Develop a daily planner application with the following capabilities:**

- Creating new entries.
- Deleting entries.
- Editing entries.

**Each individual entry should have a minimum of five fields.**

**Implement the following features:**

- Loading data from a file.
- Saving data to a file.
- Adding data to the current daily planner from a selected file.
- Importing entries within a specified date range.
- Sorting entries within the daily planner based on a selected field.

# Practical Work Objectives
Learn how to:
- Apply access modifiers.
- Create custom data types.
- Work with the Repository pattern.

# What Needs to Be Done
Enhance the program developed in module 6. Create a Worker structure with the following properties:

- ID
- Date and time of the entry
- Full Name
- Age
- Height
- Date of Birth
- Place of Birth

The Worker structure should look something like this:

```
        struct Worker
        {
            public int Id { get; set; }
            public string FIO { get; set; }
            // Other properties
        }
```
Create a `Repository` class responsible for working with instances of Worker.

The repository should implement the following functions:

- View all records.
- View a single record. The function should accept a record's ID as a parameter to display it on the screen.
- Create a record.
- Delete a record.
- Load records within a specified date range.

The `Repository` class structure might look something like this:

```
    class Repository
    {
        public Worker[] GetAllWorkers()
        {
            // Read from the file and return an array of read instances
        }

        public Worker GetWorkerById(int id)
        {
            // Read from the file and return the Worker with the requested ID
        }

        public void DeleteWorker(int id)
        {
            // Read the file, find the necessary Worker, and write all Workers to the file except the one to be deleted
        }

        public void AddWorker(Worker worker)
        {
            // Assign a unique ID to the worker and append the new worker to the file
        }

        public Worker[] GetWorkersBetweenTwoDates(DateTime dateFrom, DateTime dateTo)
        {
            // Read from the file, filter the required records, and return an array of read instances
        }
    }

```

The file's name should be stored in a private field of the `Repository` class. 
The file that the repository uses should look something like this:

```
        1#20.12.2021 00:12#Ivanov Ivan Ivanovich#25#176#05.05.1992#Moscow
        2#15.12.2021 03:12#Alekseev Alexei Ivanovich#24#176#05.11.1980#Tomsk
```

Utilizing the `Worker` structure and the `Repository` class, implement a program for working with records in the `Main` method.  
Provide the user with the ability to sort data by different fields.  
If desired, you can enhance the program with additional functionality, such as editing records, generating a specified number of records within the code (using names like "Name1," "Name2," etc.), or implementing custom functionality.

# Tips and Recommendations

- Note that the `#` symbol serves as a delimiter in the file.
- The `#` symbol should not be present when reading the file (use the `String.Split` method to split the string into an array).
- Create methods for working with records.
- Since the file does not initially exist, the program should create it upon the first run to avoid errors.
- Sorting data by fields is most conveniently accomplished using the `OrderBy` method. For example, to sort by `FIO` and `Id`:

```
    workers.OrderBy(w => w.FIO);
    workers.OrderBy(w => w.Id);
```

# Frequently Asked Questions

## What is a Class?

A class is the fundamental building block in object-oriented programming. It encapsulates data fields and methods that operate on those data fields. While it shares similarities with structures, classes in C# are used slightly differently. For a detailed understanding of classes and objects, we recommend reading the article on [Classes and Objects](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/classes).

## How to Properly Handle Dates?

When working with dates, it is essential to use the correct data type, which is `DateTime`. Under the hood, dates in C# are essentially large numbers. The higher the number, the more recent the date. Consequently, you can compare dates as if they were numbers. If `date1` is greater than `date2`, it means `date1` refers to a later date, and `date2` to an earlier one. For more details on working with `DateTime`, refer to the [Working with Dates and Times](https://docs.microsoft.com/en-us/dotnet/standard/datetime/) article.

## How to Manually Sort Data?

To manually sort data, you can implement sorting algorithms. A good starting point is the bubble sort algorithm. You can find a textual description of this algorithm online and attempt to implement it in C#. While this can be a challenging task, it's an excellent opportunity to learn. Further details about sorting objects can be found in the [Sorting Objects](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/sorting-data) article.


# Evaluation Criteria

The following criteria will be considered for evaluation:
1. **Creation of a Daily Planner**: You should create a daily planner that can store entries.
2. **Recording Creation Date**: Each entry should have a field for the creation date.
3. **Data Persistence**: All entries should be saved to disk to ensure data persistence.
4. **Data Loading**: The program should be able to load entries from the disk.
5. **Loading Entries Within Date Range**: The ability to load entries from the disk within a specified date range.
6. **Record Creation and Deletion**: Users should be able to create and delete entries.
7. **Sorting Entries**: Entries should be sortable by selecting a specific field within the main program, rather than solely within the Repository.
