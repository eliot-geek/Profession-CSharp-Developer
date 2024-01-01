namespace _06IntroFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // File
            // using System.IO; - Provides static methods for creating, copying, deleting, moving, and opening files

            // Opens a text file, reads all the lines of the file, and then closes the file.
            string text = File.ReadAllText(@"C:\Users\leosa\Downloads\PushHub\6. Files\6. Files Courses\FilesCourses\06IntroFile\data.txt");         
            Console.WriteLine(text);
            Console.ReadLine(); Console.ReadKey();

            // Opens a text file, reads all the lines of the file, and then closes the file.
            string[] lines = File.ReadAllLines(@"C:\Users\leosa\Downloads\PushHub\6. Files\6. Files Courses\FilesCourses\06IntroFile\data.txt");  
            foreach (var line in lines) 
                Console.WriteLine($"{line}");
            Console.ReadLine(); Console.ReadKey();

            // Creates a new file, writes the specified string array to the file, and then closes the file.
            lines = new string[] { "One", "Two", "Three" };
            File.WriteAllLines(@"C:\Users\leosa\Downloads\PushHub\6. Files\6. Files Courses\FilesCourses\06IntroFile\dataCreate.txt", lines);
            foreach (var line in lines)
                Console.WriteLine($"{line}");
            Console.ReadLine(); Console.ReadKey();

            // Creates a new file, writes the specified string to the file, and then closes the file. If the target file already exists, it is overwritten.
            text = "Example 2 text";
            File.WriteAllText(@"C:\Users\leosa\Downloads\PushHub\6. Files\6. Files Courses\FilesCourses\06IntroFile\dataWrite.txt", text);
            Console.WriteLine(text);
            Console.ReadLine(); Console.ReadKey();

            //File.AppendAllLines
            //File.AppendAllText

            // Copies an existing file to a new file. Overwriting a file of the same name is not allowed.
            File.Copy(@"C:\Users\leosa\Downloads\PushHub\6. Files\6. Files Courses\FilesCourses\06IntroFile\dataWrite.txt",
                @"C:\Users\leosa\Downloads\PushHub\6. Files\6. Files Courses\FilesCourses\06IntroFile\NewdataWrite.txt");
            Console.WriteLine("Copy Done"); Console.ReadKey();

            // Determines whether the specified file exists.
            File.Exists(@"C:\Users\leosa\Downloads\PushHub\6. Files\6. Files Courses\FilesCourses\06IntroFile\dataWrite.txt");
            Console.WriteLine("File Exists");  Console.ReadKey();

            // Deletes the specified file.
            File.Delete(@"C:\Users\leosa\Downloads\PushHub\6. Files\6. Files Courses\FilesCourses\06IntroFile\NewdataWrite.txt");
            Console.WriteLine("Delete Done"); Console.ReadKey();

            // Determines whether the specified file exists.
            File.Exists(@"C:\Users\leosa\Downloads\PushHub\6. Files\6. Files Courses\FilesCourses\06IntroFile\NewdataWrite.txt");
            Console.WriteLine("File Exists");  Console.ReadKey();

            // Moves a specified file to a new location and allows the file to be renamed.
            File.Move(@"C:\Users\leosa\Downloads\PushHub\6. Files\6. Files Courses\FilesCourses\06IntroFile\dataWrite.txt",
                @"C:\Users\leosa\Downloads\PushHub\6. Files\6. Files Courses\FilesCourses\dataWriteMove.txt");
            Console.WriteLine("Move Done");  Console.ReadKey();
        }
    }
}
