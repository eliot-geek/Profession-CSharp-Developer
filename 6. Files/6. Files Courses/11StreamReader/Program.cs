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
                while (!sr.EndOfStream)
                {
                    // Read a single character from the file and output its integer code and character representation
                    var c = sr.Read();
                    Console.WriteLine($"{c} - {(char)c}");
                }
            }
            Console.WriteLine(); 
            Console.ReadKey();

            using (StreamReader sr = new StreamReader("db.txt", Encoding.Unicode))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
        }
    }
}
