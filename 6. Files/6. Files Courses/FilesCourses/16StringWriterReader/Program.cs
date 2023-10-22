using System.Text;

namespace _16StringWriterReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // using System.IO;
            // Implements a System.IO.TextWriter object to write information to a string. The information is stored in the underlying System.Text.StringBuilder.

            // Create a new StringBuilder with initial capacity of 100 characters
            StringBuilder sb = new StringBuilder(100);
            // Assign a string literal to a string variable
            string s = "Advanced string manipulation: StringReader and StringWriter; mutable strings: StringBuilder";

            // Append the string to the StringBuilder
            sb.Append(s);
            // Print the contents of the StringBuilder
            Console.WriteLine(sb);
            Console.ReadKey();

            // Use a StringWriter to write additional characters to the StringBuilder
            using (StringWriter sw = new StringWriter(sb))
            {
                sw.Write("!!!");
            };
            Console.WriteLine(sb);  // Print the contents of the StringBuilder again
            Console.ReadKey();


            // Implement System.IO.TextReader reads data from a string
            // Use a StringReader to read characters from the string
            using (StringReader sr = new StringReader(s))
            {
                char[] buf = new char[5];           // Create a character buffer to store the characters read
                Console.WriteLine(sr.ReadBlock(buf, 0, buf.Length));   // Read a block of characters from the StringReader into the buffer
            };
            Console.ReadKey();
        }
    }
}