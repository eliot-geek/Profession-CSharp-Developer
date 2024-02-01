using ClientDataManagement.Change;
using ClientDataManagement.Models.Base;

namespace ClientDataManagement.ClientLibrary.Model
{
    /// <summary>
    /// Represents a client class.
    /// </summary>
    public class Client : ViewModel
    {
        // Fields

        /// <summary>
        /// ID of the client.
        /// </summary>
        private protected int id;

        /// <summary>
        /// First name of the client.
        /// </summary>
        private protected string firstName;

        /// <summary>
        /// Last name of the client.
        /// </summary>
        private protected string lastName;

        /// <summary>
        /// Middle name of the client.
        /// </summary>
        private protected string middleName;

        /// <summary>
        /// Phone number of the client.
        /// </summary>
        private protected string phoneNumber;

        /// <summary>
        /// Passport information of the client.
        /// </summary>
        private protected string passport;

        /// <summary>
        /// Change type information for the client.
        /// </summary>
        protected ChangeType ChangeType { set; get; }

        // Properties

        /// <summary>
        /// Gets or sets the ID property of the client.
        /// </summary>
        public virtual int Id
        {
            get { return id; }
            set => Set(ref id, value);
        }

        /// <summary>
        /// Gets or sets the first name property of the client.
        /// </summary>
        public virtual string FirstName
        {
            get { return firstName; }
            set => Set(ref firstName, value);
        }

        /// <summary>
        /// Gets or sets the last name property of the client.
        /// </summary>
        public virtual string LastName
        {
            get { return lastName; }
            set => Set(ref lastName, value);
        }

        /// <summary>
        /// Gets or sets the middle name property of the client.
        /// </summary>
        public virtual string MiddleName
        {
            get { return middleName; }
            set => Set(ref middleName, value);
        }

        /// <summary>
        /// Gets or sets the phone number property of the client.
        /// </summary>
        public virtual string PhoneNumber
        {
            get { return phoneNumber; }
            set => Set(ref phoneNumber, value);
        }

        /// <summary>
        /// Gets or sets the passport property of the client.
        /// </summary>
        public virtual string Passport
        {
            get { return passport; }
            set => Set(ref passport, value);
        }

        // Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class.
        /// </summary>
        /// <param name="firstname">First name of the client.</param>
        /// <param name="lastName">Last name of the client.</param>
        /// <param name="middleName">Middle name of the client.</param>
        /// <param name="phoheNumber">Phone number of the client.</param>
        /// <param name="passport">Passport information of the client.</param>
        public Client(string firstname, string lastName, string middleName, string phoheNumber, string passport)
        {
            FirstName = firstname;
            LastName = lastName;
            MiddleName = middleName;
            PhoneNumber = phoheNumber;
            Passport = passport;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class
        /// and assigns values to its properties based on another client instance.
        /// </summary>
        /// <param name="client">Another client instance to copy values from.</param>
        public Client(Client client)
        {
            this.Id = client.Id;
            this.FirstName = client.FirstName;
            this.LastName = client.LastName;
            this.MiddleName = client.MiddleName;
            this.PhoneNumber = client.PhoneNumber;
            this.Passport = client.Passport;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class.
        /// </summary>
        public Client() { }
    }
}
