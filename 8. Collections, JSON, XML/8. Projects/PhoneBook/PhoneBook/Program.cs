namespace PhoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Phone Book Application\n");
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            Phone.EnterPhoneNumbers(phoneBook);
            Phone.PrintPhoneBook(phoneBook);
            Phone.FindOwnerByPhoneNumber(phoneBook);
            Console.ReadKey();
        }
    }
}