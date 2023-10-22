namespace _08DirectoryInfo
{
    internal class Program
    {
        /// <summary>
        /// Obtains all files and folders in a selected directory
        /// </summary>
        /// <param name="path">The path to the directory</param>
        /// <param name="trim">The number of spaces for indentation</param>
        static void GetDir(string path, string trim = "")
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path); // Obtain information about the current directory

            foreach (var item in directoryInfo.GetDirectories())     // Iterate over all subdirectories of the current directory
            {
                Console.WriteLine($"{trim}{item.Name}");             // Output information about it
                GetDir(item.FullName, trim + "    ");                // Run "viewing" of the nested directory
            }

            foreach (var item in directoryInfo.GetFiles())           // Iterate over all files in the current directory
            {
                Console.WriteLine($"{trim}{item.Name}");             // Output information about them
            }
        }

        static void Main(string[] args)
        {
            // Working with files: File, FileInfo, Directory, DirectoryInfo classes
            // Directory, DirectoryInfo
            // using System.IO - Provides static methods for creating, moving, and enumerating through directories and subdirectories.

            // Directory.CreateDirectory
            // Directory.Delete
            // Directory.Exists
            // Directory.Move


            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Users\leosa\Downloads\Joke");

            Console.WriteLine(directoryInfo.Attributes);
            //directoryInfo.Create();
            //directoryInfo.Delete();
            Console.WriteLine(directoryInfo.Exists);
            Console.WriteLine(directoryInfo.FullName);
            Console.WriteLine(directoryInfo.Name);
            Console.WriteLine(directoryInfo.Root);
            Console.ReadKey();


            //directoryInfo.GetDirectories();
            foreach (var subDir in directoryInfo.GetDirectories())
            {
                Console.WriteLine(subDir.Name);
            }
            Console.WriteLine("\ndirectoryInfo.GetDirectories() Done");
            Console.ReadKey();


            //directoryInfo.GetFiles();
            foreach (var file in directoryInfo.GetFiles())
            {
                Console.WriteLine(file.Name);
            }
            Console.WriteLine("\ndirectoryInfo.GetFiles() Done");
            Console.ReadKey();


            //GetDir(@"C:\Users\leosa\Downloads\PushHub\");
            GetDir(@"C:\Program Files\Windows Defender");

            Console.ReadKey();
        }
    }
}