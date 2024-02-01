using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.IO;

namespace ClientDataManagement.ClientLibrary.Model
{
    /// <summary>
    /// Represents a repository for managing client data.
    /// </summary>
    public class Repository
    {
        /// <summary>
        /// List of clients.
        /// </summary>
        private protected ObservableCollection<Client> clients;

        /// <summary>
        /// Path to the client data file.
        /// </summary>
        private protected string path;

        /// <summary>
        /// Index of clients.
        /// </summary>
        private protected int index;

        /// <summary>
        /// Gets the list of clients.
        /// </summary>
        public ObservableCollection<Client> Clients
        {
            get { return clients; }
        }

        /// <summary>
        /// Indexer to access clients by index.
        /// </summary>
        /// <param name="index">The index of the client.</param>
        /// <returns>The client at the specified index.</returns>
        public Client this[int index]
        {
            get { return clients[index]; }
            set { clients[index] = value; }
        }

        /// <summary>
        /// Constructor for the client repository.
        /// </summary>
        /// <param name="path">The path to the client data file.</param>
        public Repository(string path)
        {
            if (File.Exists(path))
            {
                this.path = path;
            }
            else
            {
                File.Create(path).Close();
            }

            this.index = 0;
            this.clients = new ObservableCollection<Client>();
            this.Load();
        }

        /// Serialization-Deserialization

        /// <summary>
        /// Save the client data to a file.
        /// </summary>
        /// <param name="path">The path to save the client data file.</param>
        public void Save(string path)
        {
            string json = JsonConvert.SerializeObject(this.clients);
            File.WriteAllText(path, json);
        }

        /// <summary>
        /// Save the client data to the default file path.
        /// </summary>
        public void Save() => Save(this.path);

        /// <summary>
        /// Load client data from a file.
        /// </summary>
        /// <param name="path">The path from which to load the client data file.</param>
        private void Load(string path)
        {
            if (!string.IsNullOrEmpty(path) && File.Exists(path))
            {
                string json = File.ReadAllText(path);
                clients = JsonConvert.DeserializeObject<ObservableCollection<Client>>(json);
            }
            else
            {
                File.CreateText(path).Close();
            }
        }

        /// <summary>
        /// Load client data from the default file path.
        /// </summary>
        public void Load() => Load(this.path);
    }
}
