using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NoteBook
{
    /// <summary>
    /// Represents a person with associated address and phones.
    /// </summary>
    public struct Person
    {
        /// <summary>
        /// Full name of the person.
        /// </summary>
        public string name;

        /// <summary>
        /// Address details.
        /// </summary>
        public Address address;

        /// <summary>
        /// Phone details.
        /// </summary>
        public Phones phones;

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> struct.
        /// </summary>
        /// <param name="name">Full name of the person.</param>
        /// <param name="address">Address details.</param>
        /// <param name="phones">Phone details.</param>
        public Person(string name, Address address, Phones phones)
        {
            this.name = name;
            this.address = address;
            this.phones = phones;
        }
    }

    /// <summary>
    /// Represents an address with street, home number, and apartment number.
    /// </summary>
    public struct Address
    {
        /// <summary>
        /// Street information.
        /// </summary>
        public string Street;

        /// <summary>
        /// Home number.
        /// </summary>
        public string HomeNumber;

        /// <summary>
        /// Apartment number.
        /// </summary>
        public string ApartNumber;

        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> struct.
        /// </summary>
        /// <param name="street">Street information.</param>
        /// <param name="homeNumber">Home number.</param>
        /// <param name="apartNumber">Apartment number.</param>
        public Address(string street, string homeNumber, string apartNumber)
        {
            Street = street;
            HomeNumber = homeNumber;
            ApartNumber = apartNumber;
        }
    }

    /// <summary>
    /// Represents phone information with mobile and apartment phones.
    /// </summary>
    public struct Phones
    {
        /// <summary>
        /// Mobile phone number.
        /// </summary>
        public string PhoneMobile;

        /// <summary>
        /// Apartment phone number.
        /// </summary>
        public string PhoneApart;

        /// <summary>
        /// Initializes a new instance of the <see cref="Phones"/> struct.
        /// </summary>
        /// <param name="phoneMobile">Mobile phone number.</param>
        /// <param name="phoneApart">Apartment phone number.</param>
        public Phones(string phoneMobile, string phoneApart)
        {
            PhoneMobile = phoneMobile;
            PhoneApart = phoneApart;
        }
    }


    /// <summary>
    /// Class containing methods related to managing person information.
    /// </summary>
    internal class Information
    {
        /// <summary>
        /// Represents a person.
        /// </summary>
        public static Person person = new Person();

        /// <summary>
        /// Creates an XML notebook entry by taking user input for person details.
        /// </summary>
        public static void CreateXmlNoteBook()
        {
            Console.Write("Enter FullName : ");
            string name = Console.ReadLine();

            Console.Write("Enter Street : ");
            string Street = Console.ReadLine();

            Console.Write("Enter HomeNumber : ");
            string HomeNumber = Console.ReadLine();

            Console.Write("Enter ApartNumber : ");
            string ApartNumber = Console.ReadLine();

            Console.Write("Enter PhoneMobile : ");
            string PhoneMobile = Console.ReadLine();

            Console.Write("Enter PhoneApart : ");
            string PhoneApart = Console.ReadLine();

            Address Address = new Address(Street, HomeNumber, ApartNumber);
            Phones Phones = new Phones(PhoneMobile, PhoneApart);
            person = new Person(name, Address, Phones);
            Console.WriteLine("\nSuccessfully added!!");
        }

        /// <param name="Path"></param>
        /// <summary>
        /// Serializes a person object and writes it to a file.
        /// </summary>
        /// <param name="path">The path where the XML file will be created.</param>
        public static void SerializePerson(string Path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
            Stream fStream = new FileStream(Path, FileMode.Create, FileAccess.Write);
            xmlSerializer.Serialize(fStream, person);
            fStream.Close();
        }

        /// <summary>
        /// Prints the details of a person including name, address, and phone information.
        /// </summary>
        public static void PrintPersonDetails()
        {
            Console.WriteLine("\nPerson Details:");
            Console.WriteLine($"Name: {person.name}");
            Console.WriteLine($"Street: {person.address.Street}\nHomeNumber: {person.address.HomeNumber}\nApartNumber: {person.address.ApartNumber}");
            Console.WriteLine($"PhoneMobile: {person.phones.PhoneMobile}\nPhoneApart: {person.phones.PhoneApart}");
        }

    }
}
