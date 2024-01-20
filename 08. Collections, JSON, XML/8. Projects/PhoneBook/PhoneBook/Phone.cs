using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal class Phone
    {
        /// <summary>
        /// Method to enter phone numbers and full names into the phone book.
        /// </summary>
        /// <param name="phoneBook">The Dictionary representing the phone book.</param>
        public static void EnterPhoneBookEntries(Dictionary<string, string> phoneBook)
        {
            while (true)
            {
                Console.Write("Enter a phone number (or press Enter to finish): ");
                string phoneNumber = Console.ReadLine();

                if (string.IsNullOrEmpty(phoneNumber))
                    break;

                Console.Write("Enter the owner's full name: ");
                string ownerName = Console.ReadLine();

                phoneBook[phoneNumber] = ownerName;
            }
        }

        /// <summary>
        /// Find the owner by entering their phone number.
        /// </summary>
        /// <param name="phoneBook">The Dictionary representing the phone book.</param>
        public static void FindOwnerByPhoneNumber(Dictionary<string, string> phoneBook)
        {
            Console.Write("\nEnter a phone number to find the owner (or press Enter to exit): ");
            string searchNumber = Console.ReadLine();

            while (!string.IsNullOrEmpty(searchNumber))
            {
                if (phoneBook.TryGetValue(searchNumber, out string owner))
                {
                    Console.WriteLine($"Owner of {searchNumber}: {owner}");
                }
                else
                {
                    Console.WriteLine($"No owner found for {searchNumber}");
                }

                Console.Write("\nEnter another phone number to find the owner (or press Enter to exit): ");
                searchNumber = Console.ReadLine();
            }

            Console.WriteLine("\nPhone Book Application is now closed.");
        }

        /// <summary>
        /// Print the entries in the phone book.
        /// </summary>
        /// <param name="phoneBook">The Dictionary representing the phone book.</param>
        public static void PrintPhoneBook(Dictionary<string, string> phoneBook)
        {
            Console.WriteLine("\nPhone Book Entries:");
            foreach (var entry in phoneBook)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
    }

}
