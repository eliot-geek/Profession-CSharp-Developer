namespace NoteBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Address Book Application\n");
            Information.CreateXmlNoteBook();
            Information.SerializePerson("Person.xml");
            Console.ReadKey();


            Console.WriteLine("2 - Address Book Application\n");
            var personXml = CreatePersonXml.CreateXmlPerson();
            Console.WriteLine("\nXML content:");
            Console.WriteLine(personXml);
            SaveXmlToFile.SavedXmlToFile(personXml, "contact.xml");
            Console.WriteLine("\nContact information saved to 'contact.xml'");
            Console.WriteLine("Address Book Application is now closed.");
            Console.ReadLine();
        }
    }
}