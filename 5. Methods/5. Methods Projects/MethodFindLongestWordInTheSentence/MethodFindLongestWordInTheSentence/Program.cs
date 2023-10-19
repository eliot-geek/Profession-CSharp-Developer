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
        /// <param name="Text">Текст сообщения</param>
        static void Print(string Text)
        {
            Console.Write(Text);
        }

        /// <summary>
        /// method that accepts text and returns the word(s) with the maximum number of letters
        /// </summary>
        /// <param name="text"></param>
        static void MaxWord(string text)
        {
            char[] chars = { ' ', ',', '.' };
            string[] words = text.Split((chars), StringSplitOptions.RemoveEmptyEntries);
            int longest = words.Max(x => x.Length);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == longest)
                {
                    Console.Write(words[i] + " ");
                }
            }
            Console.WriteLine($"\nLength of maximal word: {longest} letter (s)");
        }

        /// <summary>
        /// method that receives text and returns the word(s) with the maximum number of letters
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static string MaxWords(string text)
        {
            // One way

            //char[] chars = { ' ', ',', '.' };                                               // Define an array of characters to be used as separators.
            //string[] words = text.Split((chars), StringSplitOptions.RemoveEmptyEntries);    // Split the input text into an array of words using the defined separator characters.
            //int longest = words.Max(x => x.Length);                                         // Get the length of the longest word in the array using LINQ.
            //string[] longestWords = words.Where(x => x.Length == longest).ToArray();        // Filter the array to include only words that have a length equal to the longest length.
            //string result = string.Join(" , ", longestWords);                               // Join the longestWords array into a single string, separated by commas.
            //return result;                                                                  // Return the resulting string.

            // Another way

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



            Print("\nEnter text: "); 
            text = Console.ReadLine();
            Print("Word(s) with maximal number of letters : ");
            MaxWord(text); 
            Delay();
        }
    }
}