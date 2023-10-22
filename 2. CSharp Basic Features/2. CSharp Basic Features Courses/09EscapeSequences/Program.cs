using System;

namespace _09EscapeSequences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Escape sequences 
            string firstName = "Alexander";
            string lastName = "Pushkin";
            string specialization = "Writer";
            byte age = 37;
            ulong yearOfBirth = 1799;
            
            // string pattern = "First Name: {0} Last Name: {1} Specialization: {2} Age: {3} Year of birth: {4}";

            #region newPattern
            string newPattern = "First Name: {0} \nLast Name: {1} \nSpecialization: {2} \nAge: {3} \nYear of birth: {4}";
            #endregion

            Console.WriteLine(newPattern,
                              firstName,
                              lastName,
                              specialization,
                              age,
                              yearOfBirth);
            Console.ReadKey();

            #region Output of Escape-sequence data
            /*
            "\n" represents a new line character.
            string message = "Hello\nWorld!";
            Console.WriteLine(message); 
            Hello
            World!

            "\r" represents a carriage return character.
            string message = "Hello\rWorld!";
            Console.WriteLine(message);
            World!

            "\t" represents a horizontal tab character.
            string message = "Name:\tJohn\tDoe\nAge:\t30";
            Console.WriteLine(message);
            Name:   John    Doe
            Age:    30

            "\'" represents a single quote character.
            string message = "She said, \"It's raining outside!\" and I replied, \'I know.\'";
            Console.WriteLine(message);
            She said, "It's raining outside!" and I replied, 'I know.'

            "\"" represents a double quote character.
            string message = "He said, \"I'm feeling good today!\"";
            Console.WriteLine(message);
            He said, "I'm feeling good today!"

            "\\" represents a reverse slash character.
            string path = "C:\\Users\\John\\Documents\\file.txt";
            Console.WriteLine(path);
            C:\Users\John\Documents\file.txt

            "\?" represents a question mark character.
            string message = "Do you want to continue? (y/n)\?";
            Console.WriteLine(message);
            Do you want to continue? (y/n)?

            */
            #endregion
        }
    }
}