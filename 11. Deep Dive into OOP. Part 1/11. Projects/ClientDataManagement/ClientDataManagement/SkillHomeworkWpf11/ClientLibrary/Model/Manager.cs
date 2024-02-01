using System;

namespace ClientDataManagement.ClientLibrary.Model
{
    /// <summary>
    /// Represents a manager class, inheriting from the <see cref="Client"/> class.
    /// </summary>
    public class Manager : Client
    {
        /// <summary>
        /// Manager constructor inheriting from <see cref="Client"/>.
        /// </summary>
        /// <param name="client">The base client instance.</param>
        public Manager(Client client) : base(client) { }

        // Properties

        /// <summary>
        /// Gets or sets the last name property of the manager.
        /// </summary>
        public override string LastName
        {
            get => base.LastName;
            set { base.LastName = value; }
        }

        /// <summary>
        /// Gets or sets the middle name property of the manager.
        /// </summary>
        public override string MiddleName
        {
            get => base.MiddleName;
            set { base.MiddleName = value; }
        }

        /// <summary>
        /// Gets or sets the first name property of the manager.
        /// </summary>
        public override string FirstName
        {
            get => base.FirstName;
            set { base.FirstName = value; }
        }

        /// <summary>
        /// Gets or sets the phone number property of the manager.
        /// </summary>
        public override string PhoneNumber
        {
            get => base.PhoneNumber;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    base.PhoneNumber = value;
                }
                phoneNumber = base.PhoneNumber;
            }
        }

        /// <summary>
        /// Gets or sets the passport property of the manager.
        /// </summary>
        public override string Passport
        {
            get => base.Passport;
            set { base.Passport = value; }
        }
    }
}
