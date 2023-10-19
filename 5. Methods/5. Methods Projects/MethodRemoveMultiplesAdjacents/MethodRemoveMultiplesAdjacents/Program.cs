﻿using System.Text;

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
        /// Method that accepts text with all multiples of adjacent characters removed, leaving one character at a time 
        /// This method removes duplicate adjacent characters from a string and returns the modified string
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static string RemoveDup(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return text;
            }

            var sb = new StringBuilder(text.Length);
            sb.Append(text[0]);

            for (var i = 1; i < text.Length; i++)
            {
                if (text[i] != text[i - 1])
                    sb.Append(text[i]);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Method that accepts text with all multiples of adjacent characters removed, leaving one character at a time
        /// This method removes duplicate adjacent characters from a string and returns the modified string.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static string RemoveMultiples(string text)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if (i == 0 || text[i] != text[i - 1])
                {
                    result.Append(text[i]);
                }
            }
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
            string newtext = "";       
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