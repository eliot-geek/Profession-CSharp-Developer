namespace _07IntroFileInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // FileInfo

            FileInfo fileInfo = new FileInfo(@"C:\Users\leosa\Downloads\PushHub\6. Files\6. Files Courses\FilesCourses\07IntroFileInfo\data.txt");

            Console.WriteLine(fileInfo.Attributes);     // Archive
            Console.WriteLine(fileInfo.Exists);         // True
            Console.WriteLine(fileInfo.Extension);      // .txt
            Console.WriteLine(fileInfo.IsReadOnly);     // False
            Console.WriteLine(fileInfo.LastAccessTime); // 03.05.2023 16:13:54
            Console.WriteLine(fileInfo.LastWriteTime);  // 03.05.2023 15:48:27

            Console.WriteLine(fileInfo.FullName);       // C:\Users\leosa\Downloads\PushHub\6. Files\6. Files Courses\FilesCourses\07IntroFileInfo\data.txt
            Console.WriteLine(fileInfo.Name);           // data.txt
            Console.WriteLine(fileInfo.DirectoryName);  // C:\Users\leosa\Downloads\PushHub\6. Files\6. Files Courses\FilesCourses\07IntroFileInfo

            Console.ReadKey();
        }
    }
}
