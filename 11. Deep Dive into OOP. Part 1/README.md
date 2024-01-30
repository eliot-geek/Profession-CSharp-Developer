# 11. Deep Dive into OOP. Part 1

## 11.1 Object-Oriented Programming Terminology: Class, Structure, Interface, Inheritance

### Object-Oriented Programming (OOP): Understanding Terminology, Classes, Structures, Interfaces

### Ideological Foundations of Object-Oriented Programming
- Abstraction
- Encapsulation
- Inheritance
- Polymorphism

### Class in Object-Oriented Programming
- Blueprint for creating objects
- Describes structure and algorithms

### Object (Instance of a Class)
- Entity in the digital space
- Possesses state and behavior
- Has fields and methods
  
### Attributes in Object-Oriented Programming
- Data members
- Instance variables

### Attributes (Variable-Member, Data Member, Class Field, Instance Variable) in OOP
- Represent the state of an object
- Also known as data members or instance variables

### Interfaces
- Data types without implementation
- Inherited by classes for method implementation

### Why Interfaces are Necessary
- Define a type with attributes and methods
- Enable multiple inheritance

### Inheritance of Interfaces
- A mechanism in OOP languages
- Allows a class to inherit multiple interfaces

### Abstract Classes
- Classes without implementation for one or more methods

### Advantages of Object-Oriented Programming
- Modularity
- Flexibility
- Time Savings

### Disadvantages of Object-Oriented Programming
- Steep Learning Curve
- Performance Impact
- Increased Code Size


## 11.2 Concept of Class, Object, Instance of a Class
- Concept of a class
- Concept of an instance of a class
- Concept of state and behavior
- Concept of Object-Oriented Programming (OOP)
- Concept of encapsulation
- Concept of inheritance
- Concept of polymorphism
- Concepts of composition, aggregation, abstraction
- Creating a class
- Analyzing the content of the Cat class
- Transforming a property into behavior
- Analyzing the content of the House class
- Creating an instance of a class
- Conclusion


## 11.3 Encapsulation, Properties, Constructors
- Analysis of the first example in ILDASM
- Analysis of the second example of encapsulation: structure
- Analysis of creating instances of classes
- Why the damage and health system is poorly described
- How to rewrite the healing logic
- How to rewrite the attack method logic
- Problem of creating heroes with the same names
- How to describe logic to eliminate the problem
- Other applications of encapsulation
- Conclusion


## 11.4 Encapsulation or Hiding?
- Encapsulation
- Access Modifiers
- **Public**: Accessible from anywhere.
- **Private**: Accessible only within the defining class.
- **Protected**: Accessible within the defining class and its subclasses.
- **Internal**: Accessible within the same assembly.
- **Protected Internal**: Accessible within the same assembly and its subclasses.
- **Private Protected**: Accessible within the same assembly and its subclasses, but only if they are in the same namespace.
- Explicit Use of Access Modifiers (involves specifying the access modifier directly)
- Implicit Use of Access Modifiers (relies on the default access level)
- Example of Encapsulation
- Ensuring Encapsulation in C#
- Conclusions


## 11.5 Inheritance
- Analysis of an example
- Breakdown of the implementation of the Druid class
- Breakdown of the implementation of the Hunter class
- Breakdown of the implementation of the Warrior class
- Code demonstration
- Evaluation of the hero system's description
- Making changes to the code
- Analysis of the inheritance of the Druid class from the Hero class
- Analysis of the inheritance of the Hunter class from the Hero class
- Analysis of the inheritance of the Warrior class from the Hero class
- Code demonstration
- Identifying issues in the inheritance of the Druid class
- Conclusion


## 11.6 Polymorphism
- Analysis of the first example
- Exploring the creation of 20 random heroes
- Running and verifying the code
- Understanding polymorphism
- Implementing polymorphism in the example
- Creating a team considering polymorphism
- Running and checking the code
- Implementation of type checking
- Running and checking the code
- Analysis of the second example
- Introducing code with a focus on polymorphism
- Running and checking the code
- Editing the code for more accurate behavior
- Running and checking the code
- How to precisely identify what can be overridden
- Conclusion


## 11.7 Abstractions, Interfaces
- Analysis of the first example: abstraction
- Prohibiting instance creation through abstraction
- Creating an abstract method
- Analysis of the second example: abstraction
- Understanding the concept of an interface
- Reasons for disallowing multiple inheritance
- Contents of interfaces
- Purpose of interfaces
- Unspoken rule of 20 lines of code
- Analysis of an example: interface
- Analysis of polymorphism from a class perspective
- Analysis of the implementation of the iRampage variable in the example
- Running and checking the code
- Creating the iRampage collection
- Properly describing interaction logic
- Conclusion
