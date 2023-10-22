namespace _20RecursiveFunctionEnumerate
{
    internal class Program
    {
        /// <summary>
        /// Define a function named Find that takes in three parameters: a character array Set, a character array Word, and an integer N
        /// </summary>
        /// <param name="Set"></param>
        /// <param name="Word"></param>
        /// <param name="N"></param>
        static void Find(char[] Set, char[] Word, int N)
        {
            // If N equals the length of the Word array
            if (N == Word.Length)
            {
                // Output each element of the Word array
                foreach (var e in Word) 
                { 
                    Console.Write(e); 
                }
                Console.WriteLine();    // Output a new line
                return;                 // Exit the function
            }

            // Create a new character array tWord and assign it to Word
            char[] tWord = Word;

            // Loop through the elements in the Set array
            for (int i = 0; i < Set.Length; i++)   
            {
                tWord[N] = Set[i];              // Assign the current element of Set to the Nth index of tWord
                Find(Set, tWord, N + 1);        // Call the Find function recursively with updated arguments
            }
        }


        static void Main(string[] args)
        {
            char[] alphabet = { 'q', 'w', 'e' };                // Define an array of characters named alphabet
            char[] currentWord = new char[3];                   // Define an array of characters named currentWord with length 4

            Find(alphabet, currentWord, 0);                     // Call the Find function with the defined arguments
        }
    }
}