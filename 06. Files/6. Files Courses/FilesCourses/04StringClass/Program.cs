namespace _04StringClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 6.2 Working with strings: static class String, instance methods.

            string str = "Visual alusiV";
            Console.WriteLine($"str = {str} ");

            // Returns the zero-based index of the first occurrence of the specified Unicode character in this string
            Console.WriteLine($"str.IndexOf('i') = {str.IndexOf('i')}");    // 1
            Console.WriteLine($"str.IndexOf('%') = {str.IndexOf('%')}");    // -1

            // Returns the zero-based index position of the last occurrence of the specified Unicode character within the current instance
            Console.WriteLine($"str.LastIndexOf('i') = {str.LastIndexOf('i')}");    // 11

            // Returns the zero-based index position of the value parameter if that character is found, or -1 if it is not.
            Console.WriteLine($"str.LastIndexOf('z') = {str.LastIndexOf('z')}");    // -1

            // Returns a new string in which a specified string is inserted at a specified index position in this instance.
            string s = str.Insert(str.IndexOf(' ') + 1, "C# ");
            Console.WriteLine($"s = {s}");

            // Returns a new string that removes all characters from the beginning to the specified position.
            Console.WriteLine($"str.Remove(6) = {str.Remove(6)}");

            // Returns a new string that removes a specified number of characters from the beginning of the string.
            Console.WriteLine($"str.Remove(6, 3) = {str.Remove(6, 3)}");

            // Returns a new string in which all occurrences of a specified Unicode character in the current instance are replaced with another specified Unicode character.
            Console.WriteLine($"str.Replace('a','z') = {str.Replace('a', 'z')}");

            // Retrieves a substring from this instance. The substring starts at a specified character position and continues to the end of the string.
            Console.WriteLine($"str.Substring(4) = {str.Substring(4)}");

            // Converts all characters in the string to uppercase and returns the result
            Console.WriteLine($"str.ToUpper() = {str.ToUpper()}");
            // Converts all characters in the string to lowercase and returns the result
            Console.WriteLine($"str.ToLower() = {str.ToLower()}");


            //str.Trim();       // Removes all leading and trailing white-space characters from the current System.String object.
            //str.TrimEnd();    // Removes all trailing occurrences of a set of characters specified in an array from the current System.String object.
            //str.TrimStart();  // Removes all leading occurrences of a set of characters specified in an array from the current System.String object.

            Console.WriteLine($"str.Trim() = {str.Trim()}");
            Console.WriteLine($"str.TrimEnd() = {str.TrimEnd()}");
            Console.WriteLine($"str.TrimStart() = {str.TrimStart()}");

            // Splits a string into substrings based on the characters in an array.
            string[] array = "1 2 3 4,5 6;7 8 9;10".Split(' ', ',', ';');

            string test = null;

            // This line checks if the string variable "test" is null or empty, and prints a boolean value indicating the result
            Console.WriteLine($"String.IsNullOrEmpty(test) = {String.IsNullOrEmpty(test)}");    // True

            test = String.Empty;
            // This line checks if the string variable "test" is null or empty, and prints a boolean value indicating the result
            Console.WriteLine($"String.IsNullOrEmpty(test) = {String.IsNullOrEmpty(test)}");    // True

            test = "Skill";
            // This line checks if the string variable "test" is null or empty, and prints a boolean value indicating the result
            Console.WriteLine($"String.IsNullOrEmpty(test) = {String.IsNullOrEmpty(test)}");    // False
        }
    }
}