namespace _04StringClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 6.2 Working with strings: static class String, instance methods.

            string str = "Visual alusiV";
            Console.WriteLine($"str = {str} ");

            // Returns the zero-based index of the first occurrence character, or -1 if it is not found
            Console.WriteLine($"str.IndexOf('i') = {str.IndexOf('i')}");    // 1
            Console.WriteLine($"str.IndexOf('%') = {str.IndexOf('%')}");    // -1

            // Returns the zero-based index of the last occurrence character
            Console.WriteLine($"str.LastIndexOf('i') = {str.LastIndexOf('i')}");    // 11
            Console.WriteLine($"str.LastIndexOf('z') = {str.LastIndexOf('z')}");    // -1

            // Returns a new string in which a specified string is inserted at a specified index position in this instance.
            string s = str.Insert(str.IndexOf(' ') + 1, "C# ");
            Console.WriteLine($"s = {s}");

            // Returns a new string that removes all characters from the beginning to the specified position.
            Console.WriteLine($"str.Remove(6) = {str.Remove(6)}");

            // Returns a new string that removes a specified number of characters from the beginning of the string.
            Console.WriteLine($"str.Remove(6, 3) = {str.Remove(6, 3)}");

            // Returns a new string in which all occurrences of a character are replaced with another character.
            Console.WriteLine($"str.Replace('a','z') = {str.Replace('a', 'z')}");

            // Retrieves a substring from this instance. The substring starts at a specified character position and continues to the end of the string.
            Console.WriteLine($"str.Substring(4) = {str.Substring(4)}");

            // Converts all characters in the string to uppercase/lowercase and returns the result
            Console.WriteLine($"str.ToUpper() = {str.ToUpper()}");
            Console.WriteLine($"str.ToLower() = {str.ToLower()}");

            //str.Trim();       // Removes all leading (start) and trailing (end) white-space characters from the current System.String object.
            //str.TrimEnd();    // Removes all trailing (end) occurrences of a set of characters specified in an array from the current System.String object.
            //str.TrimStart();  // Removes all leading (start) occurrences of a set of characters specified in an array from the current System.String object.

            Console.WriteLine($"str.Trim() = {str.Trim()}");                
            Console.WriteLine($"str.TrimEnd() = {str.TrimEnd()}");
            Console.WriteLine($"str.TrimStart() = {str.TrimStart()}");

            // Splits a string into substrings based on the characters in an array.
            string[] array = "1 2 3 4,5 6;7 8 9;10".Split(' ', ',', ';');

            // String.IsNullOrEmpty checks if a string is null or empty, and prints a boolean value (true/false)
            string test = null;
            Console.WriteLine($"String.IsNullOrEmpty(test) = {String.IsNullOrEmpty(test)}");    // True
            test = String.Empty;
            Console.WriteLine($"String.IsNullOrEmpty(test) = {String.IsNullOrEmpty(test)}");    // True
            test = "Skill";
            Console.WriteLine($"String.IsNullOrEmpty(test) = {String.IsNullOrEmpty(test)}");    // False
        }
    }
}
