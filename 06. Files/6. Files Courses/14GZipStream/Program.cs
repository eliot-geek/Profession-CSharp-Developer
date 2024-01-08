using System.IO.Compression;

namespace _14GZipStream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define the name of the source file
            string source = "war_and_peace.txt";
            // Define the name of the compressed file
            string compressed = "war_and_peace.zip";

            // Create a file stream for the source file
            using (FileStream filestream = new FileStream(source, FileMode.OpenOrCreate))
            {
                // Create a file stream for the compressed file
                using (FileStream filestreamCompressed = File.Create(compressed))   // stream for writing the compressed file
                {
                    // Create a GZipStream object to compress the data
                    using (GZipStream gzipStream = new GZipStream(filestreamCompressed, CompressionMode.Compress))
                    {
                        // Copy the contents of the source file to the compressed file
                        filestream.CopyTo(gzipStream);

                        // Print information about the compression process
                        Console.WriteLine("Compression of {0} completed. Before: {1}  After: {2}.",
                                          source,
                                          filestream.Length,
                                          filestreamCompressed.Length);
                    }
                }
            }

            Console.WriteLine($"\nPress Enter to continue\n");
            Console.ReadKey();

            // Create a file stream for the compressed file
            using (FileStream filestream = new FileStream(compressed, FileMode.OpenOrCreate))  // stream for reading from compressed file
            {
                // Create a file stream for the uncompressed file
                using (FileStream filestreamUncompressed = File.Create($"{source}_.txt")) // stream for writing the uncompressed file
                {
                    // Create a GZipStream object to decompress the data
                    using (GZipStream gzipStream2 = new GZipStream(filestream, CompressionMode.Decompress))
                    {
                        // Copy the contents of the compressed file to the uncompressed file
                        gzipStream2.CopyTo(filestreamUncompressed);

                        // Print information about the decompression process
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