using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class BankDep
    {
        public ObservableCollection<Client> Clients { get; set; }
        public abstract string Department { get; set; }
    }

    public class IndividBank : BankDep
    {
        public override string Department { get; set; } = "Customers";

        public IndividBank()
        {
            Clients = new ObservableCollection<Client>();
        }
    }
}
