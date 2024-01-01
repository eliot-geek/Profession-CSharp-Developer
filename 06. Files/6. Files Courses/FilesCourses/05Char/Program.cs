namespace _05Char
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char c = 'c';
            Console.WriteLine($"Char.IsDigit(c) = {Char.IsDigit(c)}");
            Console.WriteLine($"Char.IsLetter(c) = {Char.IsLetter(c)}");
            Console.WriteLine($"Char.IsUpper(c) = {Char.IsUpper(c)}");
            Console.WriteLine($"Char.IsLower(c) = {Char.IsLower(c)}");

            // Char.IsDigit         // Indicates whether the specified Unicode character is categorized as a decimal digit.
            // Char.IsLetter        // Indicates whether the specified Unicode character is categorized as a Unicode letter.
            // Char.IsLower         // Indicates whether the specified Unicode character is categorized as a lowercase letter.
            // Char.IsUpper         // Indicates whether the specified Unicode character is categorized as an uppercase letter.

            char[] symbols = "symbols".ToCharArray();
            foreach (var item in symbols) 
                Console.Write($"{item} ");
            Console.ReadLine();


            string s = new String(symbols);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}