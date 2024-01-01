namespace _11NumbersAfterPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double d = 123456.654321;
            Console.WriteLine(d); // 123456.654321

            string dFormated = d.ToString("#.###");
            Console.WriteLine(dFormated);               // 123456,654
            Console.WriteLine("{0:0.000}", d);          // 123456,654
            Console.WriteLine(d.ToString("#.####"));    // 123456,6543

            dFormated = d.ToString("#.## ## ## ## ##");
            Console.WriteLine(dFormated); // 123456,65 43 21

            dFormated = d.ToString("### ###.## ## ## ## ##");
            Console.WriteLine(dFormated); // 123,456.65 43 21   
            Console.WriteLine("{0:000,000,000,000,000,000,000}", d); // 000 123,456,654 321,000

            #region Note

            // Depending on the settings of the language standard of the program.
            // the output characters can be different. 
            Console.WriteLine();
            var date = new DateTime(2025, 09, 28, 01, 30, 59);
            Console.WriteLine(date);

            Console.ReadKey();
            Console.WriteLine($"{date:HH:mm}");
            Console.WriteLine($"{date:yyyy-MM-dd}");
            Console.WriteLine($"{date:yyy.MM.dd}");
            Console.WriteLine($"{date:dd.MM.yyyy}");
            #endregion
        }
    }
}