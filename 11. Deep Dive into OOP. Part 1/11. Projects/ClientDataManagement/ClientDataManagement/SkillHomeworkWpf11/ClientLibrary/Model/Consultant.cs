using System;

namespace ClientDataManagement.ClientLibrary.Model
{
    /// <summary>
    /// Represents a consultant class, inheriting from the <see cref="Client"/> class.
    /// </summary>
    public class Consultant : Client
    {
        /// <summary>
        /// Consultant constructor inheriting from <see cref="Client"/>.
        /// </summary>
        /// <param name="client">The base client instance.</param>
        public Consultant(Client client) : base(client) { }

        // Properties

        /// <summary>
        /// Gets or sets the last name property of the consultant.
        /// </summary>
        public override string LastName
        {
            get => base.LastName;
            set
            {
                OnPropertyChanged(nameof(base.LastName));
            }
        }

        /// <summary>
        /// Gets or sets the middle name property of the consultant.
        /// </summary>
        public override string MiddleName
        {
            get => base.MiddleName;
            set
            {
                OnPropertyChanged(nameof(base.MiddleName));
            }
        }

        /// <summary>
        /// Gets or sets the first name property of the consultant.
        /// </summary>
        public override string FirstName
        {
            get => base.FirstName;
            set
            {
                OnPropertyChanged(nameof(base.FirstName));
            }
        }

        /// <summary>
        /// Gets or sets the passport property of the consultant.
        /// </summary>
        public override string Passport
        {
            get
            {
                if (!string.IsNullOrEmpty(base.Passport))
                {
                    return "**** ******";
                }
                return string.Empty;
            }
            set
            {
                OnPropertyChanged(nameof(base.Passport));
            }
        }

        /// <summary>
        /// Gets or sets the phone number property of the consultant.
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
    }
}
