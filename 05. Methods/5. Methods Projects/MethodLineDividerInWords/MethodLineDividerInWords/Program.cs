using System.Text;

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
        /// Splits a given string into words manually using a loop.
        /// </summary>
        /// <param name="text">The input string to be split into words.</param>
        /// <returns>An array of words.</returns>
        static string[] SplitTextManually(string text)
        {
            List<string> wordsList = new List<string>();
            StringBuilder currentWord = new StringBuilder();

            foreach (char character in text)
            {
                if (character == ' ')
                {
                    if (currentWord.Length > 0)
                    {
                        wordsList.Add(currentWord.ToString());
                        currentWord.Clear();
                    }
                }
                else
                {
                    currentWord.Append(character);
                }
            }

            if (currentWord.Length > 0)
            {
                wordsList.Add(currentWord.ToString());
            }

            return wordsList.ToArray();
        }

        /// <summary>
        /// Method to output the words on separate lines
        /// </summary>
        /// <param name="words"></param>
        static void OutputWords(string[] words)
        {
            Console.WriteLine("\nWords in the sentence: ");
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
            string[] wordsManually = SplitTextManually(input);

            OutputWords(words);
            OutputWords(wordsManually);
            Console.ReadKey();
        }
    }
}
