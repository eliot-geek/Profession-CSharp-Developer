namespace _13FileStream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FileStream

            Console.Write("Enter a string: ");
            string text = Console.ReadLine();

            // Writing to a file
            // Using a FileStream to create or overwrite the file "note.txt"
            using (FileStream fstream = new FileStream(@"note.txt", FileMode.Create))
            {
                // Convert the string to bytes
                byte[] array = System.Text.Encoding.Default.GetBytes(text);

                // Write the byte array to the file
                fstream.Write(array, 0, array.Length);
            }

            // Reading from a file
            // Using a FileStream to open the existing file "note.txt" for reading
            using (FileStream fstream = File.OpenRead(@"note.txt"))
            {
                // Create a byte array to store the file content
                byte[] array = new byte[fstream.Length];

                // Read the data from the file into the byte array
                fstream.Read(array, 0, array.Length);

                // Decode the bytes to a string
                text = System.Text.Encoding.Default.GetString(array);

                // Output the retrieved text to the console
                Console.WriteLine($"Text: {text}");
            }
            Console.ReadLine();

            #endregion
        }
    }
}