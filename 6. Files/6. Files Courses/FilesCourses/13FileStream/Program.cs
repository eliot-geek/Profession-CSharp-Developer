namespace _13FileStream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FileStream

            Console.Write("Enter a string: ");
            string text = Console.ReadLine();

            // writing to a file
            using (FileStream fstream = new FileStream(@"note.txt", FileMode.Create))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text); // convert string to bytes
                fstream.Write(array, 0, array.Length); // write byte array to file
            }

            // reading from a file
            using (FileStream fstream = File.OpenRead(@"note.txt"))
            {
                byte[] array = new byte[fstream.Length]; // convert string to bytes
                fstream.Read(array, 0, array.Length);       // read the data

                text = System.Text.Encoding.Default.GetString(array);    // decode bytes to string
                Console.WriteLine($"Text: {text}");
            }
            Console.ReadLine();

            #endregion
        }
    }
}