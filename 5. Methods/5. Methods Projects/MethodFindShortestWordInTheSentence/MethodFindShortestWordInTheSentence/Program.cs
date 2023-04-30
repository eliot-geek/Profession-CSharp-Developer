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
            // Define an array of characters to be used as separators.
            char[] chars = { ' ', ',', '.' };
            // Split the input text into an array of words using the defined separator characters.
            string[] words = text.Split((chars), StringSplitOptions.RemoveEmptyEntries);
            // Get the length of the shortest word in the array using LINQ.
            int shortest = words.Min(x => x.Length);

            // Iterate through each word in the array.
            for (int i = 0; i < words.Length; i++)
            {
                // If the length of the current word is equal to the shortest length, print the word.
                if (words[i].Length == shortest)
                {
                    Console.Write(words[i] + " ");
                }
            }
            // Print the length of the shortest word to the console.
            Console.WriteLine($"\nLength of the minimum word: {shortest} letter(s)");
        }

        static string FindShortestWord(string text)
        {
            // Split the input text into an array of words.
            string[] words = text.Split(new char[] { ' ', ',', '.', ':', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            // Initialize the shortest word to be the first word in the array.
            string shortestWord = words[0];

            // Iterate through each word in the array and compare its length to the current shortest word.
            foreach (string word in words)
            {
                if (word.Length < shortestWord.Length)
                {
                    // If the current word is shorter than the current shortest word, update the shortest word.
                    shortestWord = word;
                }
            }
            // Return the shortest word.
            return shortestWord;
        }

        static void Main(string[] args)
        {
            // Call the FindShortestWord method with an example string.
            string exampleText = "The quick brown fox jumps over the lazy dog";
            Print(exampleText);
            string shortestWord = FindShortestWord(exampleText);
            // Print the result to the console.
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