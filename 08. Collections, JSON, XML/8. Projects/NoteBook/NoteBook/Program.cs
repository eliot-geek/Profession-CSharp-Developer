namespace NoteBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Address Book Application (XElement)");
            var personXml = CreatePersonXml.CreateXmlPerson();
            Console.WriteLine("\nXML content\n");
            Console.WriteLine(personXml);
            SaveXmlToFile.SavedXmlToFile(personXml, "contact.xml");
            Console.WriteLine("\nCheck the XML file \'contact.xml\' in your folder.");
            Console.ReadLine();


            Console.WriteLine("2 - Address Book Application");
            Information.CreateXmlNoteBook();
            Information.SerializePerson("Person.xml");
            Console.WriteLine("\nCheck the XML file \'Person.xml\' in your folder.");
            Information.PrintPersonDetails();
            Console.ReadLine();
        }
    }
}