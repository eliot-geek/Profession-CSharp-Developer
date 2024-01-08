namespace _09StreamsClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Working with streams: StreamWriter and StreamReader

            // Retrieve all directories on the C:\ drive
            var dirs = new DirectoryInfo(@"c:\").GetDirectories();
            StreamWriter streamWriter = new StreamWriter("cDirs.txt");

            // Iterate through each directory in the array
            foreach (DirectoryInfo dir in dirs)
            {
                streamWriter.WriteLine(dir.FullName);
                Console.WriteLine($">> {dir.FullName}");
            }
            Console.ReadKey();

            // Clean the buffer and ensure data is written to the file
            streamWriter.Flush();

            // Close the StreamWriter to release resources or no access
            streamWriter.Close();
            Console.ReadKey();


            #region Theory

            // Note 1. After working with a stream, it is necessary to close it using void Close() or at least write to the file the current data in the buffer
            // using void Flush(); // streamWriter.Flush();

            // Note 2. StreamWriter is designed to output characters in a specific encoding, while classes derived from Stream are designed for input and output of bytes.

            // Note 3. For more convenient work with streams (in general, and not only), C# has the using operator, which provides a convenient syntax and ensures
            // the correct use of IDisposable objects.

            #endregion


            #region keyword using

            using (StreamWriter sw = new StreamWriter("cDirs.txt"))  
            {
                foreach (DirectoryInfo dir in dirs)
                {
                    // Write the current directory name to the file
                    sw.WriteLine(dir.Name);   
                }
            }

            using (StreamReader sr = new StreamReader("cDirs.txt"))  
            {
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());  
                }
            }
            Console.ReadKey();

            #endregion

        }
    }
}