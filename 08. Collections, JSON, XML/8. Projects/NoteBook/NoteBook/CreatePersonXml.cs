using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NoteBook
{
    internal class CreatePersonXml
    {
        /// <summary>
        /// Creates an XML representation of a person by taking user input for person details.
        /// </summary>
        /// <returns>XElement representing the person's information.</returns>
        public static XElement CreateXmlPerson()
        {
            Console.Write("Enter Full Name: ");
            string fullName = Console.ReadLine();

            Console.Write("Enter Street: ");
            string street = Console.ReadLine();

            Console.Write("Enter House Number: ");
            string houseNumber = Console.ReadLine();

            Console.Write("Enter Flat Number: ");
            string flatNumber = Console.ReadLine();

            Console.Write("Enter Mobile Phone: ");
            string mobilePhone = Console.ReadLine();

            Console.Write("Enter Home Phone: ");
            string homePhone = Console.ReadLine();

            // Create an XElement representing the person with nested Address and Phones elements
            var personXml = new XElement("Person",
                new XAttribute("name", fullName),
                new XElement("Address",
                    new XElement("Street", street),
                    new XElement("HouseNumber", houseNumber),
                    new XElement("FlatNumber", flatNumber)
                ),
                new XElement("Phones",
                    new XElement("MobilePhone", mobilePhone),
                    new XElement("HomePhone", homePhone)
                )
            );

            return personXml;
        }
    }
}
