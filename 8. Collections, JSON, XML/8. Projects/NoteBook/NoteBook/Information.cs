using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NoteBook
{
    /// <summary>
    /// Person 
    /// </summary>
    public struct Person
    {
        public string name;
        public Address address;
        public Phones phones;

        public Person(string name, Address address, Phones phones)
        {
            this.name = name;
            this.address = address;
            this.phones = phones;
        }
    }

    /// <summary>
    /// Address
    /// </summary>
    public struct Address
    {
        public string Street;
        public string HomeNumber;
        public string ApartNumber;

        public Address(string street, string homeNumber, string apartNumber)
        {
            Street = street;
            HomeNumber = homeNumber;
            ApartNumber = apartNumber;
        }
    }

    /// <summary>
    /// Phones
    /// </summary>
    public struct Phones
    {
        public string PhoneMobile;
        public string PhoneApart;

        public Phones(string phoneMobile, string phoneApart)
        {
            PhoneMobile = phoneMobile;
            PhoneApart = phoneApart;
        }
    }


    /// <summary>
    /// Information
    /// </summary>
    internal class Information
    {
        public static Person person = new Person();
        
        /// <summary>
        /// Creation Xml NoteBook
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
            Console.WriteLine("Successfully added!!");
        }

        /// <summary>
        /// Person Sterilization Method
        /// </summary>
        /// <param name="Path"></param>
        public static void SerializePerson(string Path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
            Stream fStream = new FileStream(Path, FileMode.Create, FileAccess.Write);
            xmlSerializer.Serialize(fStream, person);
            fStream.Close();
        }
    }
}
