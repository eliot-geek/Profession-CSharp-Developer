using System.Text;

namespace _15StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem with string

            string s1 = "Hllo";                             
            string s2 = s1.Insert(1, "e");                  
            Console.WriteLine($"s1 = {s1}, s2 = {s2}");     
            Console.WriteLine("Allocated memory size");     
            Console.WriteLine($"s1 = {s1.Length * 2} bytes, s2 = {s2.Length * 2} bytes"); 
            Console.WriteLine(s1[1]);
            
            //s1[1] = '!';            // attempt to modify the character at index 1 of s1 (which will result in a compilation error)
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

            sb2.Append("One "); // Appends a copy of the specified string to this instance.
            Console.WriteLine($"sb2 = {sb2}, sb2.Length = {sb2.Length}, sb2.Capacity = {sb2.Capacity}");
            Console.ReadKey();

            sb2.AppendFormat("{0} {1} ", "Two", "Three"); // Appends the string returned by processing a composite format string to this instance
            Console.WriteLine($"sb2 = {sb2}, sb2.Length = {sb2.Length}, sb2.Capacity = {sb2.Capacity}");
            Console.ReadKey();

            sb2.AppendLine(); // Appends the default line terminator to the end of the current StringBuilder object
            Console.WriteLine($"sb2 = {sb2}, sb2.Length = {sb2.Length}, sb2.Capacity = {sb2.Capacity}");
            Console.ReadKey();

            sb2.AppendLine("Four");  // Appends a copy of the specified string and the default line terminator to the end of the current StringBuilder object.
            Console.WriteLine($"sb2 = {sb2}, sb2.Length = {sb2.Length}, sb2.Capacity = {sb2.Capacity}");
            Console.ReadKey();

            sb2.Remove(1, 1);  // Removes the specified range of characters from this instance.
            Console.WriteLine(sb2);
            Console.ReadKey();

            sb2.Replace('O', 'o'); // Replaces all occurrences of a specified character in this instance with another specified character.
            sb2.Replace('T', 't'); // Replaces all occurrences of a specified character in this instance with another specified character.
            sb2.Replace('O', 'o'); // Replaces all occurrences of a specified character in this instance with another specified character.
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
