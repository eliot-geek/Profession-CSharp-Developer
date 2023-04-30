using System.Text;

namespace MethodRemoveMultiplesAdjacents
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
        static void Print(string text)
        {
            Console.Write(text);
        }

        /// <summary>
        /// method that accepts text with all multiples of adjacent characters removed, leaving one character at a time 
        /// This method removes duplicate adjacent characters from a string and returns the modified string
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static string RemoveDup(string text)
        {
            // If the string is null or empty, return the string as-is
            if (string.IsNullOrEmpty(text))
            {
                return text;
            }

            // Create a new StringBuilder object to store the modified string
            var sb = new StringBuilder(text.Length);
            // Append the first character of the input string to the StringBuilder
            sb.Append(text[0]);


            // Loop through the input string, starting at the second character
            for (var i = 1; i < text.Length; i++)
            {
                // If the current character is not equal to the previous character, append it to the StringBuilder
                if (text[i] != text[i - 1])
                    sb.Append(text[i]);
            }
            // Return the modified string as a string
            return sb.ToString();
        }

        /// <summary>
        /// method that accepts text with all multiples of adjacent characters removed, leaving one character at a time
        /// This method removes duplicate adjacent characters from a string and returns the modified string.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static string RemoveMultiples(string text)
        {
            // Initialize an empty StringBuilder object to hold the result.
            StringBuilder result = new StringBuilder();

            // Loop through each character in the input text.
            for (int i = 0; i < text.Length; i++)
            {
                // If the current character is the first character or is different from the previous character, append it to the result StringBuilder object.
                if (i == 0 || text[i] != text[i - 1])
                {
                    result.Append(text[i]);
                }
            }
            // Convert the result StringBuilder object to a string and return it.
            return result.ToString();
        }

        static void Main(string[] args)
        {
            string text1 = "WEEEEATTTTTTHEEEEEEEEERRRRRRRRR";
            string result1 = RemoveMultiples(text1);
            Console.WriteLine($"Result 1: {result1}");

            string text2 = "WWWONNNDEEEFUULLL DDDDAAAAAAYYY";
            string result2 = RemoveMultiples(text2);
            Console.WriteLine($"Result 2: {result2}");



            Print("\nEnter text with multiples: ");
            string text = Console.ReadLine();
            string newtext = "";        // letter level to be the same
            foreach (var c in text)
            {
                if (char.IsUpper(c))
                    newtext += char.ToLower(c);
                else
                    newtext += char.ToLower(c);
            }
            Print("Letter conversion: ");
            Console.WriteLine(newtext);
            Print("Text with all multiples removed: ");
            Console.WriteLine(RemoveDup(newtext));
            Delay();
        }
    }
}