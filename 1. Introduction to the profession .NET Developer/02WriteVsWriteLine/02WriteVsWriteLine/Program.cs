namespace _02WriteVsWriteLine
{
    internal class Program
    {
        /// <summary>
        /// The code that is executed first
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            Console.Write("Hello "); // Text output to the console using which does not wrap the string
            Console.Write("World "); 
            Console.Write("!!!"); 

            Console.ReadLine();  
        }
    }
}