using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NoteBook
{
    internal class SaveXmlToFile
    {
        /// <summary>
        /// Saves the provided XElement to a file with the specified fileName.
        /// </summary>
        /// <param name="xml">XElement to be saved.</param>
        /// <param name="fileName">Name of the file to save the XElement.</param>
        public static void SavedXmlToFile(XElement xml, string fileName)
        {
            xml.Save(fileName);
        }
    }
}
