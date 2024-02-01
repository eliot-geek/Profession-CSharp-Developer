# Client Data Management System with OOP Principles

## Secure Client Profile

### Objective:
Develop a consultant program for Bank "A" to view client data. The consultant has no rights to modify or view certain data. Create a class that contains the following fields:

- Last Name
- First Name
- Patronymic
- Phone Number
- Passport Series and Number

Implement access methods for the following situations:

1. The consultant has no access to view information. Instead of the passport series and number, they see symbols: "******************," if the field is not empty.
2. The consultant cannot modify the fields "Last Name," "First Name," "Patronymic," but can view them.
3. The consultant can modify the "Phone Number," but the field must always be filled.

### Recommendations:
You can use either a console application or an application with a graphical user interface. Specify data types at your discretion. Also, decide where and how the data will be stored.

### Evaluation Criteria:
- Use of encapsulation.
- Correct description of data in the class.
- Presence of a constructor in the class.

## User Data Control

### Objective:
Extend the program from Secure Client Profile. We have a class for a consultant with its methods and fields. Add a new class for a new user - a manager.

The manager inherits the consultant's functionality in addition to its own. At the same time, the manager can only add "Last Name," "First Name," "Patronymic," "Phone," "Passport Series and Number."

### Recommendations:
You can use either a console application or an application with a graphical user interface. Specify data types as you see fit, ensuring that they match the data. Also, at your discretion, decide where and how the data will be stored (text file with a delimiter is recommended). If implemented as a console application, there should be a choice at launch between a consultant or a manager. If a graphical interface is used, you can use the WPF ComboBox component.

### Evaluation Criteria:
- Use of inheritance.
- Correct description of data in the class.
- Presence of a constructor in the class.

## Managerial Data Access

### Objective:
Extend and modify the program from Secure Client Profile and User Data Control. We have two classes for a consultant and a manager. The classes have methods to change data. Based on this, add additional fields to the data from Task 1:

- Date and time of record modification.
- What data is changed.
- Type of changes.
- Who changed the data (consultant or manager).

Also, create interfaces and implement methods in them for modifying an existing record for the consultant and manager. For the manager, allow adding a new record. Fill in the new fields as soon as client records are modified. Now, the consultant can only change the client's phone number, while the manager can change all data.

### Recommendations:
You can use either a console application or an application with a graphical user interface. Specify data types as you see fit, ensuring that they match the data. Also, at your discretion, decide where and how the data will be stored (text file with a delimiter is recommended). If implemented as a console application, there should be a choice at launch between a consultant or a manager. If a graphical interface is used, you can use the WPF ComboBox component.

### Evaluation Criteria:
- Use of polymorphism.
- Presence of interfaces.
- Correct description of data in the class.
- Presence of a constructor in the classes.
