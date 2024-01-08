using System.Text;

namespace _11StreamReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Open the "db.txt" file for reading using StreamReader and Unicode encoding
            using (StreamReader sr = new StreamReader("db.txt", Encoding.Unicode))
            {
                // Loop through the file until the end is reached
                while (!sr.EndOfStream)
                {
                    // Read a single character from the file and output its integer code and character representation
                    var c = sr.Read();
                    Console.WriteLine($"{c} - {(char)c}");
                }
            }
            Console.WriteLine(); 
            Console.ReadKey();

            // Open the "db.txt" file for reading using StreamReader and Unicode encoding
            using (StreamReader sr = new StreamReader("db.txt", Encoding.Unicode))
            {
                // Read the entire contents of the file and output it to the console
                Console.WriteLine(sr.ReadToEnd());
            }
        }
    }
}