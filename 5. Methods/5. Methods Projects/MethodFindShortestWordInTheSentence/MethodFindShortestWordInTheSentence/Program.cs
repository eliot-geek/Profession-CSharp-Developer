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
        /// <param name="Text">Текст сообщения</param>
        static void Print(string Text)
        {
            Console.Write(Text);
        }

        /// <summary>
        /// Method that accepts text and returns a word with the minimum number of letters
        /// </summary>
        /// <param name="text"></param>
        static void MinWord(string text)
        {
            char[] chars = { ' ', ',', '.' };
            string[] words = text.Split((chars), StringSplitOptions.RemoveEmptyEntries);
            int shortest = words.Min(x => x.Length);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == shortest)
                {
                    Console.Write(words[i] + " ");
                }
            }
            Console.WriteLine($"\nLength of the minimum word: {shortest} letter(s)");
        }


        
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
            // Call the FindShortestWord method with an example string.
            string exampleText = "The quick brown fox jumps over the lazy dog";
            Print(exampleText);
            string shortestWord = FindShortestWord(exampleText);
            Console.WriteLine("\nThe shortest word in the text is: " + shortestWord);
            Console.ReadKey();



            Print("\nEnter text: ");
            string text = Console.ReadLine();
            Print(text);
            Print("\nWord(s) with the minimum number of letters : ");
            MinWord(text);                                              
            Delay(); 
        }
    }
}
