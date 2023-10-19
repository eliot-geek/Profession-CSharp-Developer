namespace MethodLineDividerInWords
{
    internal class Program
    {
        /// <summary>
        /// Method to split the input string into words
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static string[] SplitText(string text)
        {
            return text.Split(' ');
        }

        /// <summary>
        /// Method to output the words on separate lines
        /// </summary>
        /// <param name="words"></param>
        static void OutputWords(string[] words)
        {
            Console.WriteLine("Words in the sentence: ");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a long sentence: ");
            string input = Console.ReadLine();

            string[] words = SplitText(input);
            OutputWords(words);
            Console.ReadKey();
        }
    }
}
