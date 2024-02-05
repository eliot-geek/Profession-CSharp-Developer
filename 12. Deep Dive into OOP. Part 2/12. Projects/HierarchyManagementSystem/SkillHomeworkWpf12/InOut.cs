using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HierarchyManagementSystem
{
    /// <summary>
    /// Represents a class for input and output operations implementing the IIO interface.
    /// </summary>
    class InOut : IIO
    {
        string json;

        /// <summary>
        /// Saves the data to a file using JSON serialization.
        /// </summary>
        public void SaveData()
        {
            json = JsonConvert.SerializeObject(Core.org);

            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "data";
            save.DefaultExt = ".json";
            save.Filter = "JSON file (.json)|*.json";

            if (save.ShowDialog() == true)
            {
                string filename = save.FileName;
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    sw.WriteLine(json);
                }
            }
            
            MessageBox.Show("Data successfully saved", "Save data", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        /// <summary>
        /// Loads employees from a JSON file.
        /// </summary>
        /// <returns>The loaded ObservableCollection of Organisation.</returns>
        public ObservableCollection<Organisation> LoadData()
        {
            OpenFileDialog load = new OpenFileDialog();
            load.FileName = "data";
            load.DefaultExt = ".json";
            load.Filter = "JSON file (.json)|*.json";

            if (load.ShowDialog() == true)
            {
                string filename = load.FileName;

                using (StreamReader sr = new StreamReader(filename))
                {
                    json = sr.ReadToEnd();
                }

                JsonConverter[] converters = { new EmployeeConverter() };
                Core.org = JsonConvert.DeserializeObject<ObservableCollection<Organisation>>(json, new JsonSerializerSettings() { Converters = converters });
            }

            MessageBox.Show("Data successsfully loaded", "Load data", MessageBoxButton.OK, MessageBoxImage.Information);
            return Core.org;
        }

        /// <summary>
        /// Custom JSON converter for handling polymorphic serialization and deserialization of Employee types.
        /// </summary>
        public class EmployeeConverter : JsonConverter
        {
            /// <summary>
            /// Determines whether this converter can convert the specified type.
            /// </summary>
            public override bool CanConvert(Type objectType)
            {
                return (objectType == typeof(Employee));
            }

            /// <summary>
            /// Reads the JSON representation of an Employee object.
            /// </summary>
            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                JObject jo = JObject.Load(reader);

                if (jo["Position"].Value<string>() == "CEO")
                    return jo.ToObject<CEO>(serializer);

                if (jo["Position"].Value<string>() == "Administrator")
                    return jo.ToObject<Administrator>(serializer);

                if (jo["Position"].Value<string>() == "Manager")
                    return jo.ToObject<Manager>(serializer);

                if (jo["Position"].Value<string>() == "Staff")
                    return jo.ToObject<Staff>(serializer);

                if (jo["Position"].Value<string>() == "Intern")
                    return jo.ToObject<Intern>(serializer);

                return null;

                //switch (jo["Position"].Value<string>())
                //{
                //    case "CEO":
                //        return jo.ToObject<CEO>(serializer);
                //    case "Administrator":
                //        return jo.ToObject<Administrator>(serializer);
                //    case "Manager":
                //        return jo.ToObject<Manager>(serializer);
                //    case "Staff":
                //        return jo.ToObject<Staff>(serializer);
                //    case "Intern":
                //        return jo.ToObject<Intern>(serializer);
                //    default:
                //        return null;
                //}
            }

            /// <summary>
            /// Indicates whether this converter can write JSON.
            /// </summary>
            public override bool CanWrite
            {
                get { return false; }
            }

            /// <summary>
            /// Writes the JSON representation of an object. Not implemented in this converter.
            /// </summary>
            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                throw new NotImplementedException();
            }
        }
    }
}
