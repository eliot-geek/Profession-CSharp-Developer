namespace MethodSentenceRearrangementReverse
{
    internal class Program
    {
        /// <summary>
        /// Splits the input text into an array of words using space as the delimiter.
        /// Removes any empty entries from the resulting array.
        /// </summary>
        /// <param name="text">The input text to be split into words.</param>
        /// <returns>An array of words obtained from the input text.</returns>
        static string[] SplitText(string text)
        {
            return text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //return text.Split(' ');
        }

        /// <summary>
        /// Reverses the order of words in the input text.
        /// Calls the SplitText method to obtain an array of words.
        /// Iterates through the array in reverse order and builds a reversed phrase.
        /// </summary>
        /// <param name="text">The input text whose words need to be rearranged.</param>
        /// <returns>The input text with its words reversed in order.</returns>
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
