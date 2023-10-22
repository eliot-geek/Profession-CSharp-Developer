namespace _01ConvertClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lesson 1: Built-in methods. Convert class
            // Converts the value of one primitive data type to another primitive data type.

            //bool
            //byte
            //char
            //DateTime
            //decimal
            //double
            //short
            //int
            //long
            //sbyte
            //float
            //string
            //ushort
            //uint
            //ulong

            int i = Convert.ToByte("20"); // with a value larger than byte its'a an overflow
            Console.WriteLine(i);
            Console.ReadKey();

            byte j = byte.Parse("20");    // with a value larger than byte its'a an overflow
            Console.WriteLine(j);
            Console.ReadKey();

            j = (byte)int.Parse("2011"); // This works but not exactly
            Console.WriteLine(j);
            Console.ReadKey();

            i = Convert.ToByte(12.45); // 12
            Console.WriteLine(i);

            i = Convert.ToByte(56.78f); // 57
            Console.WriteLine(i);
            
            i = Convert.ToByte(89.09m);     // 89
            Console.WriteLine(i);

        }
    }
}