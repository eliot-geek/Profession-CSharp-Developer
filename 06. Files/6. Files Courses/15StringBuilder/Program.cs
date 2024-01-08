using System.Text;

namespace _15StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem with string

            // Initialize the string variable with the value "Hllo"
            string s1 = "Hllo";

            // Insert the letter "e" at position 2 of string s1 and assign it to s2
            string s2 = s1.Insert(1, "e");

            // Print both strings
            Console.WriteLine($"s1 = {s1}, s2 = {s2}");

            // Print "Allocated memory size"
            Console.WriteLine("Allocated memory size");

            // Print the allocated memory size of s1 and s2 in bytes
            Console.WriteLine($"s1 = {s1.Length * 2} bytes, s2 = {s2.Length * 2} bytes");

            // Print the character at index 1 of s1
            Console.WriteLine(s1[1]);

            // Attempt to modify the character at index 1 of s1
            // (Note: This line is commented out because it will result in a compilation error)
            // s1[1] = '!';

            Console.ReadKey();

            #endregion


            #region StringBuilder

            // using System.Text - StringBuilder - provides a mutable string of characters.

            StringBuilder sb1 = new StringBuilder("Hllo");
            Console.WriteLine($"\nLength sb1 = {sb1.Length}");
            Console.WriteLine($"Capacity sb1 = {sb1.Capacity}");

            StringBuilder sb2 = new StringBuilder(100);
            Console.WriteLine($"\nLength sb2 = {sb2.Length}");
            Console.WriteLine($"Capacity sb2 = {sb2.Capacity}");

            //public StringBuilder();
            //public StringBuilder(int capacity);
            //public StringBuilder(string value);
            //public StringBuilder(string value, int capacity);
            //public StringBuilder(int capacity, int maxCapacity);
            //public StringBuilder(string value, int startIndex, int length, int capacity);

            // Appends a copy of the specified string to this instance.
            sb2.Append("One "); 
            Console.WriteLine($"sb2 = {sb2}, sb2.Length = {sb2.Length}, sb2.Capacity = {sb2.Capacity}");
            Console.ReadKey();

            // Appends the string returned by processing a composite format string to this instance
            sb2.AppendFormat("{0} {1} ", "Two", "Three"); 
            Console.WriteLine($"sb2 = {sb2}, sb2.Length = {sb2.Length}, sb2.Capacity = {sb2.Capacity}");
            Console.ReadKey();

            // Appends the default line terminator to the end of the current StringBuilder object
            sb2.AppendLine(); 
            Console.WriteLine($"sb2 = {sb2}, sb2.Length = {sb2.Length}, sb2.Capacity = {sb2.Capacity}");
            Console.ReadKey();

            // Appends a copy of the specified string and the default line terminator to the end of the current StringBuilder object.
            sb2.AppendLine("Four");  
            Console.WriteLine($"sb2 = {sb2}, sb2.Length = {sb2.Length}, sb2.Capacity = {sb2.Capacity}");
            Console.ReadKey();

            // Removes the specified range of characters from this instance.
            sb2.Remove(1, 1); 
            Console.WriteLine(sb2);
            Console.ReadKey();

            // Replaces all occurrences of a specified character in this instance with another specified character.
            sb2.Replace('O', 'o'); 
            sb2.Replace('T', 't'); 
            sb2.Replace('O', 'o');
            Console.ReadKey();


            //public StringBuilder Replace(string oldValue, string newValue);
            //public StringBuilder Replace(string oldValue, string newValue, int startIndex, int count);
            //public StringBuilder Replace(char oldChar, char newChar);
            //public StringBuilder Replace(char oldChar, char newChar, int startIndex, int count);

            sb2[4] = '!';
            Console.WriteLine(sb2);

            #endregion


            #region Recommendations for use

            // String 
            // A small number of operations and changes of string elements
            // When you need to perform a search, such as IndexOf, i.e. StringBuilder has no such methods.

            // StringBuilder
            // If the number of operations which will be performed on strings during the program execution is unknown.

            #endregion
        }
    }
}