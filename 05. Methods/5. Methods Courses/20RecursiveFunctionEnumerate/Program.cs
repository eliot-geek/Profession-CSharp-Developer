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
            if (N == Word.Length)
            {
                foreach (var e in Word) 
                { 
                    Console.Write(e); 
                }
                Console.WriteLine();    
                return;                
            }
            char[] tWord = Word;
            
            for (int i = 0; i < Set.Length; i++)   
            {
                tWord[N] = Set[i];              // Assign the current element of Set to the Nth index of tWord
                Find(Set, tWord, N + 1);        // Call the Find function recursively with updated arguments
            }
        }


        static void Main(string[] args)
        {
            char[] alphabet = { 'q', 'w', 'e' };                // Define an array of characters named alphabet
            char[] currentWord = new char[3];                   // Define an array of characters named currentWord with length

            Find(alphabet, currentWord, 0);                     // Call the Find function with the defined arguments
        }
    }
}
