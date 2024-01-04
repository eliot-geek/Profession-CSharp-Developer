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
                tWord[N] = Set[i];              
                Find(Set, tWord, N + 1);       
            }
        }


        static void Main(string[] args)
        {
            char[] alphabet = { 'q', 'w', 'e' };               
            char[] currentWord = new char[3];       
            Find(alphabet, currentWord, 0); 
        }
    }
}
