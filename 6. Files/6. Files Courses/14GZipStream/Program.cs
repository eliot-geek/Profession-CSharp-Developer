using System.IO.Compression;

namespace _14GZipStream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string source = "war_and_peace.txt";
            string compressed = "war_and_peace.zip";

            using (FileStream filestream = new FileStream(source, FileMode.OpenOrCreate))
            {
                using (FileStream filestreamCompressed = File.Create(compressed))                                     // stream for writing the compressed file
                {
                    using (GZipStream gzipStream = new GZipStream(filestreamCompressed, CompressionMode.Compress))    // to compress the data
                    {
                        filestream.CopyTo(gzipStream);        // Copy the contents of the source file to the compressed file
                        Console.WriteLine("Compression of {0} completed. Before: {1}  After: {2}.",
                                          source,
                                          filestream.Length,
                                          filestreamCompressed.Length);
                    }
                }
            }

            Console.WriteLine($"Press Enter to continue\n");
            Console.ReadKey();

            using (FileStream filestream = new FileStream(compressed, FileMode.OpenOrCreate))                 // Stream for reading from compressed file
            {
                using (FileStream filestreamUncompressed = File.Create($"{source}_.txt"))                     // Stream for writing the uncompressed file
                {
                    using (GZipStream gzipStream2 = new GZipStream(filestream, CompressionMode.Decompress))   // GZipStream object to decompress the data
                    {
                        gzipStream2.CopyTo(filestreamUncompressed);                                           // Copy the contents of the compressed file to the uncompressed file
                        Console.WriteLine($"{source} has been restored");
                        Console.WriteLine("Restoration of {0} completed. Before: {1}  After: {2}.",
                                          source,
                                          filestream.Length,
                                          filestreamUncompressed.Length);
                    }
                }
            }
        }
    }
}
