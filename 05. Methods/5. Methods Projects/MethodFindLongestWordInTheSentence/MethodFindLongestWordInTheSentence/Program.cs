namespace MethodFindLongestWordInTheSentence
{
    internal class Program
    {
        /// <summary>
        /// A method to make the console close delayed
        /// </summary>
        static void Delay()
        {
            Console.ReadKey();
        }

        /// <summary>
        /// A method to display the message in the console
        /// </summary>
        /// <param name="Text">Message Text</param>
        static void Print(string Text)
        {
            Console.Write(Text);
        }

        /// <summary>
        /// Analyzes the input text and outputs the word(s) with the maximum number of letters.
        /// </summary>
        /// <param name="text">The input text to be processed.</param>
        static void FindMaxLengthWords(string text)
        {
            char[] separators = { ' ', ',', '.' };
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            int longestLength = words.Max(x => x.Length);

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == longestLength)
                {
                    Console.Write(words[i] + " ");
                }
            }

            Console.WriteLine($"\nLength of maximal word: {longestLength} letter(s)");
        }


        /// <summary>
        /// Analyzes the input text and returns the word(s) with the maximum number of letters.
        /// </summary>
        /// <param name="text">The input text to be processed.</param>
        /// <returns>The word(s) with the maximum number of letters.</returns>
        static string MaxWords(string text)
        {
            char[] separators = { ' ', ',', '.' };
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            // One way to find the maximum words using LINQ
            int longestLength = words.Max(x => x.Length);
            string[] longestWords = words.Where(x => x.Length == longestLength).ToArray();
            return string.Join(", ", longestWords);
        }

        /// <summary>
        /// Analyzes the input text and returns the word with the maximum number of letters.
        /// </summary>
        /// <param name="text">The input text to be processed.</param>
        /// <returns>The word with the maximum number of letters.</returns>
        static string MaxWord(string text)
        {
            char[] chars = { ' ', ',', '.' };
            string[] words = text.Split((chars), StringSplitOptions.RemoveEmptyEntries);
            string longestWord = words[0];

            foreach (string word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }

            return longestWord;
        }


        static void Main(string[] args)
        {
            string text = "The sun sets slowly on the horizon";
            string maxWords = MaxWords(text);
            Console.WriteLine($"Longest word(s): {maxWords}");

            string maxWord = MaxWord(text);
            Console.WriteLine($"Longest word(s): {maxWord}");

            Print("\nEnter text: "); 
            text = Console.ReadLine();
            Print("Word(s) with maximal number of letters : ");
            FindMaxLengthWords(text); 
            Delay();
        }
    }
}