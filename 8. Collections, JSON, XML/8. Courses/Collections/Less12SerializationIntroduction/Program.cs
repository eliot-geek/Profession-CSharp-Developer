using System.Runtime.Intrinsics.X86;

namespace Less12SerializationIntroduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Serialization - the process of translating any data structure into a sequence of bits.
            // Deserialization - the restoration of the initial state of a data structure from a bit sequence.
            // For example, in video games, when you exit the game and return later to find yourself in the same place and at the same level where you left off, this continuity is achieved
            // through serialization and deserialization. It involves storing game data and then, when you re-enter the game, retrieving that data to resume from where you last saved.

            #region CSV (Comma-Separated Values)

            /* CSV stands for Comma-Separated Values. It is a plain text format used to represent tabular data, such as a spreadsheet or a database.
            - Each line represents a row of data.
            - The values within each row are separated by commas.
            - The first row typically contains headers, which represent the names of the columns or fields.
            - Following rows contain the actual data, where each value corresponds to a specific column.

            CSV files are widely used for data storage and exchange because of their simplicity and compatibility with various applications. 
            They can be easily imported into spreadsheet software or processed by programs to work with the contained data. */


            // Name_1,LastName_1,Position_778,4931,Department_94
            // Name_2,LastName_2,Position_368,3838,Department_88
            // Name_3,LastName_3,Position_731,4746,Department_4
            // Name_4,LastName_4,Position_917,3765,Department_7
            // Name_5,LastName_5,Position_671,1791,Department_96
            // Name_6,LastName_6,Position_753,1671,Department_99
            // Name_7,LastName_7,Position_162,4487,Department_28
            // Name_8,LastName_8,Position_294,2937,Department_5
            // Name_9,LastName_9,Position_125,2318,Department_35
            // Name_10,LastName_10,Position_151,2657,Department_50
            // Name_11,LastName_11,Position_425,2367,Department_89

            #endregion


            #region XML (Extensible Markup Language)

            /* XML (Extensible Markup Language) is a markup language used for representing structured data. 
            It uses tags to define elements and attributes, allowing for hierarchical and structured data representation.
            - Structure: XML provides a more structured way of representing data due to its hierarchical nature. 
            - Human-Readability: XML is more human-readable than CSV because it includes both data and labels (element and attribute names).
            - Extensibility: XML allows for custom-defined structures and data types, making it more flexible for various use cases.

            XML files tend to be larger and less space-efficient than CSV because of the additional markup and tags. 
            This increased size can lead to slower file I/O and higher storage requirements. 

            In terms of speed and efficiency, CSV files are often considered faster to read and write because they contain raw data with minimal formatting.
             
            XML is preferred when you need a structured and hierarchical representation of data, 
            whereas CSV is more suitable for simple tabular data that needs to be efficiently processed and transmitted.  */


            // <?xml version="1.0"?>
            // <ArrayOfWorker xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
            //   <Worker>
            //     <FirstName>Name_1</FirstName>
            //     <LastName>LastName_1</LastName>
            //     <Position>Position_1</Position>
            //     <Department>Department_1</Department>
            //     <Salary>1000</Salary>
            //   </Worker>
            //   <Worker>
            //     <FirstName>Name_2</FirstName>
            //     <LastName>LastName_2</LastName>
            //     <Position>Position_2</Position>
            //     <Department>Department_2</Department>
            //     <Salary>2000</Salary>
            //   </Worker>
            //   <Worker>
            //     <FirstName>Name_3</FirstName>
            //     <LastName>LastName_3</LastName>
            //     <Position>Position_3</Position>
            //     <Department>Department_3</Department>
            //     <Salary>3000</Salary>
            //   </Worker>
            //   <Worker>
            //     <FirstName>Name_4</FirstName>
            //     <LastName>LastName_4</LastName>
            //     <Position>Position_4</Position>
            //     <Department>Department_4</Department>
            //     <Salary>4000</Salary>
            //   </Worker>
            //   <Worker>
            //     <FirstName>Name_5</FirstName>
            //     <LastName>LastName_5</LastName>
            //     <Position>Position_5</Position>
            //     <Department>Department_5</Department>
            //     <Salary>5000</Salary>
            //   </Worker>
            // </ArrayOfWorker>

            #endregion


            #region JSON (JavaScript Object Notation)

            /* JSON (JavaScript Object Notation) is a lightweight data-interchange format. It is easy for humans to read and write and easy for machines to parse and generate. 
             * JSON is often used to transmit data between a server and a web application, as well as for configuration files and data storage.
            - The data is represented as an array of objects enclosed in square brackets [].
            - Each object is enclosed in curly braces {} and contains key-value pairs.
            - The keys (e.g., "FirstName," etc..) are strings that serve as labels for the corresponding values.
            - The values can be of various data types, including strings, numbers, and nested objects or arrays.
            
            JSON is a popular format for data exchange for several reasons:
            - Human-Readable: JSON is relatively easy for humans to read and write, thanks to its simple and intuitive structure.
            - Lightweight: JSON is lightweight, meaning it doesn't include a lot of unnecessary characters or markup, resulting in smaller file sizes compared to XML.
            - Wide Adoption: JSON is widely adopted and supported in various programming languages, making it an excellent choice for interoperability between different systems.
            - Easy to Parse: JSON is easy for machines to parse, making it efficient for data serialization and deserialization.

            - Performance: JSON is generally faster to parse and serialize than XML because it's simpler and has less overhead. JSON parsers are available for most programming languages and are often highly optimized.
            - Flexibility: JSON is more flexible than CSV because it supports complex data structures, whereas CSV is essentially tabular data with limited support for nested or hierarchical data.
            - Human-Readability: JSON is more human-readable than XML due to its straightforward syntax, but it may not be as readable as CSV for simple tabular data.
            - Storage Efficiency: JSON files tend to be more space-efficient than XML because they include less metadata.
            
            JSON is often considered faster, more space-efficient, and more flexible than XML and is a popular choice for data interchange, especially in web applications and web services. */

            // [
            //   {
            //     "FirstName": "Name_1",
            //     "LastName": "LastName_1",
            //     "Position": "Position_1",
            //     "Department": "Department_1",
            //     "Salary": 1000
            //   },
            //   {
            //     "FirstName": "Name_2",
            //     "LastName": "LastName_2",
            //     "Position": "Position_2",
            //     "Department": "Department_2",
            //     "Salary": 2000
            //   },
            //   {
            //     "FirstName": "Name_3",
            //     "LastName": "LastName_3",
            //     "Position": "Position_3",
            //     "Department": "Department_3",
            //     "Salary": 3000
            //   },
            //   {
            //     "FirstName": "Name_4",
            //     "LastName": "LastName_4",
            //     "Position": "Position_4",
            //     "Department": "Department_4",
            //     "Salary": 4000
            //   },
            //   {
            //     "FirstName": "Name_5",
            //     "LastName": "LastName_5",
            //     "Position": "Position_5",
            //     "Department": "Department_5",
            //     "Salary": 5000
            //   }
            // ]

            #endregion

            // Each format has its strengths and weaknesses, and the choice between them should be based on the specific needs of your project.
            // Whether XML or CSV is "faster" depends on the specific use case and requirements. 
            // Whether JSON is faster than CSV depends on the specific use case and how the data is structured.
            // For structured, nested data, JSON is typically faster and more appropriate, while CSV may be faster for simple tabular data.
        }
    }
}