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
            string s = "Advanced string manipulation: StringReader and StringWriter; mutable strings: StringBuilder";
            sb.Append(s);
            Console.WriteLine(sb);
            Console.ReadKey();

            // Use a StringWriter to write additional characters to the StringBuilder
            using (StringWriter sw = new StringWriter(sb))
            {
                sw.Write("!!!");
            };
            Console.WriteLine(sb);
            Console.ReadKey();


            // Implement System.IO.TextReader reads data from a string
            // Use a StringReader to read characters from the string
            using (StringReader sr = new StringReader(s))
            {
                // Create a character buffer to store the characters read
                char[] buf = new char[5];
                // Read a block of characters from the StringReader into the buffer
                Console.WriteLine(sr.ReadBlock(buf, 0, buf.Length));   
            };
            Console.ReadKey();
        }
    }
}