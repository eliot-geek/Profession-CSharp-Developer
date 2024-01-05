namespace MethodFindShortestWordInTheSentence
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
        /// <param name="Text">Message of the Text</param>
        static void Print(string Text)
        {
            Console.Write(Text);
        }

        /// <summary>
        /// Analyzes the input text and outputs the word with the minimum number of letters.
        /// </summary>
        /// <param name="text">The input text to be processed.</param>
        static void FindMinLengthWord(string text)
        {
            char[] separators = { ' ', ',', '.' };
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int shortestLength = words.Min(x => x.Length);

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == shortestLength)
                {
                    Console.Write(words[i] + " ");
                }
            }

            Console.WriteLine($"\nLength of the minimum word: {shortestLength} letter(s)");
        }

        /// <summary>
        /// Finds and returns the word with the minimum number of letters in the given text.
        /// </summary>
        /// <param name="text">The input text to be processed.</param>
        /// <returns>The word with the minimum number of letters.</returns>
        static string FindShortestWord(string text)
        {
            string[] words = text.Split(new char[] { ' ', ',', '.', ':', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            string shortestWord = words[0];

            foreach (string word in words)
            {
                if (word.Length < shortestWord.Length)
                {
                    shortestWord = word;
                }
            }

            return shortestWord;
        }


        static void Main(string[] args)
        {
            string exampleText = "The quick brown fox jumps over the lazy dog";
            Print(exampleText);
            string shortestWord = FindShortestWord(exampleText);
            Console.WriteLine("\nThe shortest word in the text is: " + shortestWord);
            Console.ReadKey();



            Print("\nEnter text: ");
            string text = Console.ReadLine();
            Print(text);
            Print("\nWord(s) with the minimum number of letters : ");
            FindMinLengthWord(text);                                              
            Delay(); 
        }
    }
}
