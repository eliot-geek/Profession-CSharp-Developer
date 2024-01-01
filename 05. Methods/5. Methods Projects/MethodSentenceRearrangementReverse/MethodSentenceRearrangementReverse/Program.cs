namespace MethodSentenceRearrangementReverse
{
    internal class Program
    {
        /// <summary>
        /// Splits the input phrase into an array of words
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static string[] SplitText(string text)
        {
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return words;
        }

        /// <summary>
        /// Reverses the order of words in the sentence
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static string ReverseWords(string text)
        {
            string[] words = SplitText(text);
            string reversedPhrase = "";
            for (int i = words.Length - 1; i >= 0; i--)
            {
                reversedPhrase += words[i] + " ";
            }
            return reversedPhrase.TrimEnd();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence:");
            string inputPhrase = Console.ReadLine();
            string reversedPhrase = ReverseWords(inputPhrase);
            Console.WriteLine("Reversed sentence:");
            Console.WriteLine(reversedPhrase);
        }
    }
}
