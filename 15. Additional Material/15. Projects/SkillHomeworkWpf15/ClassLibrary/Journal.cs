using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Journal
    {
        public ObservableCollection<string> journalFile = new ObservableCollection<string>();

        public void AddToJournal(string message)
        {
            journalFile.Add(message);
        }
    }
}
