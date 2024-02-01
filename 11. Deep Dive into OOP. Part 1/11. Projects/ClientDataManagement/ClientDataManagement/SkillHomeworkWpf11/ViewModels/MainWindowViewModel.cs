using ClientDataManagement.ClientLibrary.Model;
using ClientDataManagement.MainWindowLibrary.ViewModel.Commands;
using ClientDataManagement.Models;
using ClientDataManagement.Models.Base;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace ClientDataManagement.ViewModels
{
    /// <summary>
    /// View model for the main window of the application, inheriting from ViewModel.
    /// </summary>
    internal class MainWindowViewModel : ViewModel
    {
        private string _title = "Bank A";

        /// <summary>
        /// Window Head
        /// </summary>
        public string Title
        {
            get => _title;
            set => Set(ref _title, value);
        }

        /// Commands

        /// <summary>
        /// Command to close the application.
        /// </summary>
        public ICommand CloseApplicationCommand { get; }

        /// <summary>
        /// Determines whether the close application command can be executed.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        private bool CanCloseApplicationCommandExecute(object p) => true;

        /// <summary>
        /// Executes the close application command.
        /// </summary>
        /// <param name="p"></param>
        private void OnCloseApplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }

        /// <summary>
        /// Command to add a new client.
        /// </summary>
        public ICommand AddClientCommand { get; }

        /// <summary>
        /// Determines whether the add client command can be executed.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        private bool CanAddClientCommand(object p)
        {
            if (User == UserType.Consultant)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Executes the add client command.
        /// </summary>
        /// <param name="p"></param>
        private void OnAddClientCommand(object p)
        {
            Client client = new Client();
            Repository.Clients.Add(client);
            SelectedClient = client;
        }

        /// <summary>
        /// Command to save client data.
        /// </summary>
        public ICommand SaveDateClient { get; }

        /// <summary>
        /// Determines whether the save client data command can be executed.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        private bool CanSaveDateClient(object p)
        {
            if (SelectedClient != null)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Executes the save client data command.
        /// </summary>
        /// <param name="p"></param>
        private void OnSaveDateClient(object p)
        {
            Client client = Repository.Clients[SelectedClient.Id];
            client.Id = _selectedClient.Id;
            client.FirstName = _selectedClient.FirstName;
            client.LastName = SelectedClient.LastName;
            client.MiddleName = SelectedClient.MiddleName;
            client.PhoneNumber = SelectedClient.PhoneNumber;
            client.Passport = SelectedClient.Passport;
        }

        /// <summary>
        /// Enumeration of user types
        /// </summary>
        public enum UserType
        {
            [Description("Consultant")]
            Consultant,
            [Description("Manager")]
            Manager,
        }

        /// <summary>
        /// List-listing of users
        /// </summary>
        readonly EnumListItemCollection<UserType> users = new EnumListItemCollection<UserType>();

        /// <summary>
        /// User's type
        /// </summary>
        UserType userType;

        /// <summary>
        /// List-listing of users
        /// </summary>
        public EnumListItemCollection<UserType> Users
        {
            get => users;
        }

        /// <summary>
        /// User's Type
        /// </summary>
        public UserType User
        {
            get => userType;
            set => Set(ref userType, value);
        }

        /// <summary>
        /// Selected Client
        /// </summary>
        private Client _selectedClient;
        
        /// <summary>
        /// SelectedClient
        /// </summary>
        public Client SelectedClient
        {
            get
            {
                if (_selectedClient == null)
                {
                    _selectedClient = new Client();
                }
                switch (User)
                {
                    case UserType.Consultant:
                        _selectedClient = new Consultant(_selectedClient);
                        break;
                    case UserType.Manager:
                        _selectedClient = new Manager(_selectedClient);
                        break;
                    default:
                        break;
                }
                return _selectedClient;

            }
            set => Set(ref _selectedClient, value);
        }
        
        /// <summary>
        /// Property Repository
        /// </summary>
        public Repository Repository
        {
            get;
        }

        /// <summary>
        /// Main Window Model
        /// </summary>
        public MainWindowViewModel()
        {
            /// <summary>
            /// Creating a customer repository
            /// </summary>
            Repository = new Repository("Clients");

            /// Commands
            CloseApplicationCommand = new RelayCommands(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);
            AddClientCommand = new RelayCommands(OnAddClientCommand, CanAddClientCommand);
            SaveDateClient = new RelayCommands(OnSaveDateClient, CanSaveDateClient);
        }
    }
}
