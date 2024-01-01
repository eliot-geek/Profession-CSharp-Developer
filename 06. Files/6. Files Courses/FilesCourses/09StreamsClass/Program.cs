namespace _09StreamsClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Working with streams: StreamWriter and StreamReader

            var dirs = new DirectoryInfo(@"c:\").GetDirectories();      // dirs stores all directories on the C:\ drive

            StreamWriter streamWriter = new StreamWriter("cDirs.txt");  // Creating a "stream" for working with the cDirs.txt file
            foreach (DirectoryInfo dir in dirs)
            {
                streamWriter.WriteLine(dir.FullName);       // Write the current directory name to the file
                Console.WriteLine($">> {dir.FullName}");
            }
            Console.ReadKey();

            streamWriter.Flush();       // Clean Buffer
            streamWriter.Close();       // Close the "stream" - if we don't close it's gonna be empty and impossible to delete for example and to do some other things (no access)
            Console.ReadKey();


            #region Theory

            // Note 1. After working with a stream, it is necessary to close it using void Close() or at least write to the file the current data in the buffer
            // using void Flush(); // streamWriter.Flush();

            // Note 2. StreamWriter is designed to output characters in a specific encoding, while classes derived from Stream are designed for input and output of bytes.

            // Note 3. For more convenient work with streams (in general, and not only), C# has the using operator, which provides a convenient syntax and ensures
            // the correct use of IDisposable objects.

            #endregion


            #region Using keyword

            // Creating a "stream" for working with the file cDirs.txt
            using (StreamWriter sw = new StreamWriter("cDirs.txt"))  
            {
                foreach (DirectoryInfo dir in dirs)
                {
                    // Write the current directory name to the file
                    sw.WriteLine(dir.Name);   
                }
            }

            // Stream for reading
            // Creating a "stream" for working with the file cDirs.txt
            using (StreamReader sr = new StreamReader("cDirs.txt"))  
            {
                while (!sr.EndOfStream)
                {
                    // Write the current directory name to the file
                    Console.WriteLine(sr.ReadLine());  
                }
            }
            Console.ReadKey();

            #endregion

        }
    }
}