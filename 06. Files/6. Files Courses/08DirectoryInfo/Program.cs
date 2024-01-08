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
            // Obtain information about the current directory
            DirectoryInfo directoryInfo = new DirectoryInfo(path);

            // Iterate over all subdirectories of the current directory
            foreach (var item in directoryInfo.GetDirectories())
            {
                // Output information about the subdirectory
                Console.WriteLine($"{trim}{item.Name}");

                // Recursively call GetDir to view the nested directory
                GetDir(item.FullName, trim + "    ");
            }

            // Iterate over all files in the current directory
            foreach (var item in directoryInfo.GetFiles())
            {
                // Output information about the file
                Console.WriteLine($"{trim}{item.Name}");
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


            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Users");

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


            //GetDir(@"C:\Users");
            GetDir(@"C:\Program Files\Windows Defender");

            Console.ReadKey();
        }
    }
}