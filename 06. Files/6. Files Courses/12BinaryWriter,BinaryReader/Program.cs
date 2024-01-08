namespace _12BinaryWriter_BinaryReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region BinaryWriter, BinaryReader

            string[] names = { "Julia", "Irina", "Chloe", "Sara", "Alice" };
            string path = @"BinaryNames.dat";

            // Write the names array to the binary file
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                // Write the value of each field in the structure to a file.
                foreach (var name in names)
                {
                    writer.Write(name);
                }
            }
            Console.WriteLine($"File {path} has been successfully created. Press Enter to continue\n");
            Console.ReadKey();

            // Open the file with BinaryReader to read binary data
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                // Loop through each character in the file until end of file is reached
                while (reader.PeekChar() > -1)
                {
                    // Read the binary data and convert it to a string using the ReadString() method
                    string name = reader.ReadString();
                    Console.WriteLine(name);
                }
            }
            Console.ReadKey();

            #endregion

        }
    }
}