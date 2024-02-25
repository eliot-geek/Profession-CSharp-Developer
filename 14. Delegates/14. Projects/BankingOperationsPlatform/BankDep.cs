using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BankingOperationsPlatform
{
    /// <summary>
    /// Abstract class representing a bank department with deposit functionality.
    /// </summary>
    public abstract class BankDep
    {
        /// <summary>
        /// Gets or sets the collection of clients associated with this bank department.
        /// </summary>
        public ObservableCollection<Client> Clients
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the department name.
        /// </summary>
        public abstract string Department
        {
            get; set;
        }
    }

    /// <summary>
    /// Represents a bank department specialized for individual clients.
    /// </summary>
    internal class IndividBank : BankDep
    {
        /// <summary>
        /// Gets or sets the department name.
        /// </summary>
        public override string Department
        {
            get; set;
        } = "Individual";

        /// <summary>
        /// Initializes a new instance of the <see cref="IndividBank"/> class.
        /// </summary>
        public IndividBank()
        {
            Clients = new ObservableCollection<Client>();
        }
    }

    /// <summary>
    /// Represents a bank department specialized for business clients.
    /// </summary>
    internal class BusinessBank : BankDep
    {
        /// <summary>
        /// Gets or sets the department name.
        /// </summary>
        public override string Department
        {
            get; set;
        } = "Business";

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessBank"/> class.
        /// </summary>
        public BusinessBank()
        {
            Clients = new ObservableCollection<Client>();
        }
    }


    /// <summary>
    /// Represents a bank department specialized for VIP clients.
    /// </summary>
    internal class VipBank : BankDep
    {
        /// <summary>
        /// Gets or sets the department name.
        /// </summary>
        public override string Department
        {
            get; set;
        } = "VIP";

        /// <summary>
        /// Initializes a new instance of the <see cref="VipBank"/> class.
        /// </summary>
        public VipBank()
        {
            Clients = new ObservableCollection<Client>();
        }
    }
}