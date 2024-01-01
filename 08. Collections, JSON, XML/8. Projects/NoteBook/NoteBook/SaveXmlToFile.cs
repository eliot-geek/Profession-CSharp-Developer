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
        public static void SavedXmlToFile(XElement xml, string fileName)
        {
            xml.Save(fileName);
        }
    }
}
