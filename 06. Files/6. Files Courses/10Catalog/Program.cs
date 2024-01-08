using System.Text;

namespace _10Catalog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Need to create a file that simulates a notepad.
            // The file contains:
            // Author's name
            // Date
            // Note description
            // Town

            // Writer
            using (StreamWriter sw = new StreamWriter("db.csv", true, Encoding.Unicode))
            {
                char key = 'y';
                do
                {
                    string note = string.Empty;
                    Console.Write("\nEnter the author's name: ");
                    note += $"{Console.ReadLine()}\t";
                    
                    string now = DateTime.Now.ToShortTimeString();
                    Console.Write($"Note time : {now}");
                    note += $"{now}\t";
                    
                    Console.Write("\nEnter note description: ");
                    note += $"{Console.ReadLine()}\t";
                    sw.WriteLine(note);
                    
                    Console.Write("Continue y/n : ");
                    key = Console.ReadKey(true).KeyChar;

                } while (char.ToLower(key) == 'y');
            }
            Console.ReadKey();

            // Reader
            using (StreamReader sr = new StreamReader("data.csv", Encoding.Unicode))
            {
                string line;
                Console.WriteLine($"\n\n{"Author",15}{" Time",6} {"Description"}");

                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split('\t');
                    Console.WriteLine($"{data[0],15}{data[1],6} {data[2]}");
                }
            }

            // Find the file here : C:\bin\Debug\net6.0
        }
    }
}