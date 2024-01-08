namespace _06IntroFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Working with files: File, FileInfo, Directory, DirectoryInfo classes
            // using System.IO; - Provides static methods for creating, copying, deleting, moving, and opening files

            // Opens a text file, reads all the lines of the file, and then closes the file.
            string text = File.ReadAllText(@"C:\Users\data.txt");         
            Console.WriteLine(text);
            Console.ReadLine(); Console.ReadKey();

            // Opens a text file, reads all the lines of the file, and then closes the file.
            string[] lines = File.ReadAllLines(@"C:\Users\data.txt");
            foreach (var line in lines) 
                Console.WriteLine($"{line}");
            Console.ReadLine(); Console.ReadKey();

            // Creates a new file, writes the specified string array to the file, and then closes the file.
            lines = new string[] { "One", "Two", "Three" };
            File.WriteAllLines(@"C:\Users\dataCreate.txt", lines);
            foreach (var line in lines)
                Console.WriteLine($"{line}");
            Console.ReadLine(); Console.ReadKey();

            // Creates a new file, writes the specified string to the file, and then closes the file.
            // If the target file already exists, it is overwritten.
            text = "Example 2 text";
            File.WriteAllText(@"C:\Users\dataWrite.txt", text);
            Console.WriteLine(text);
            Console.ReadLine(); Console.ReadKey();


            // Both methods are convenient for adding content without overwriting their existing content.
            // These methods will create the file if it doesn't already exist

            // File.AppendAllLines - Appends an array of strings as lines to the end of a file.
            string[] linesToAdd = { "New line 1", "New line 2", "New line 3" };
            File.AppendAllLines(@"C:\Users\example.txt", linesToAdd);

            // File.AppendAllText - Appends a specified string to the end of a file.
            string textToAdd = "This is some additional text.";
            File.AppendAllText(@"C:\Users\example.txt", textToAdd);


            // Copies an existing file to a new file. Overwriting a file of the same name is not allowed.
            File.Copy(@"C:\Users\dataWrite.txt", @"C:\Users\NewdataWrite.txt");
            Console.WriteLine("Copy Done"); 
            Console.ReadKey();

            // Determines whether the specified file exists.
            File.Exists(@"C:\Users\dataWrite.txt");
            Console.WriteLine("File Existence Checked");  
            Console.ReadKey();

            // Deletes the specified file.
            File.Delete(@"C:\Users\NewdataWrite.txt");
            Console.WriteLine("Delete Done"); 
            Console.ReadKey();

            // Determines whether the specified file exists.
            File.Exists(@"C:\Users\NewdataWrite.txt");
            Console.WriteLine("File Existence Checked");
            Console.ReadKey();

            // Moves a specified file to a new location and allows the file to be renamed.
            File.Move(@"C:\Users\dataWrite.txt", @"C:\Users\dataWriteMove.txt");
            Console.WriteLine("Move Done");  
            Console.ReadKey();
        }
    }
}