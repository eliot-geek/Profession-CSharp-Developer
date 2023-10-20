using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DailyPlannerApp
{
    public class Diary
    {
        /// <summary>
        /// List to store records
        /// Creation of the list
        /// </summary>
        public List<Record> records { get; set; } = new List<Record>();

        /// <summary>
        /// Load records from a JSON file into the list                             
        /// </summary>
        public void Load()
        {
            try
            {
                records = JsonSerializer.Deserialize<Diary>(File.ReadAllText(@"diary.json"))?.records;
            }
            catch (Exception)
            {
                Console.WriteLine("File does not exist.");
            }
        }

        /// <summary>
        /// Save the list of records to a JSON file
        /// </summary>
        public void Save()
        {
            File.WriteAllText(@"diary.json", JsonSerializer.Serialize(this));
        }

        /// <summary>
        /// Add a single record to the list
        /// </summary>
        /// <param name="record">The record to be added</param>
        public void AddRecord(Record record)
        {
            records.Add(record);
        }

        /// <summary>
        /// Add a collection of records to the list
        /// </summary>
        /// <param name="_records">Collection of records to be added</param>
        public void AddRecords(IEnumerable<Record> _records)
        {
            records.AddRange(_records);
        }

        /// <summary>
        /// Delete a specific record from the list
        /// </summary>
        /// <param name="record">The record to be deleted</param>
        public void DeleteRecord(Record record)
        {
            records.Remove(record);
        }

        /// <summary>
        /// Delete a collection of records from the list
        /// </summary>
        /// <param name="_records">Collection of records to be deleted</param>
        public void DeleteRecords(IEnumerable<Record> _records)
        {
            foreach (var record in _records)
            {
                records.Remove(record);
            }
        }

        /// <summary>
        /// Delete records by their Id
        /// </summary>
        /// <param name="id">The Id to match and delete</param>
        public void DeleteById(long id)
        {
            var Records = records.Where(record => record.Id == id);
            DeleteRecords(Records);
        }

        /// <summary>
        /// Delete records by their Topic
        /// </summary>
        /// <param name="topic">The Topic to match and delete</param>
        public void DeleteByTopic(string topic)
        {
            var Records = records.Where(record => record.Topic == topic);
            DeleteRecords(Records);
        }

        /// <summary>
        /// Delete records by their Body
        /// </summary>
        /// <param name="body">The Body to match and delete</param>
        public void DeleteByBody(string body)
        {
            var Records = records.Where(record => record.Body == body);
            DeleteRecords(Records);
        }

        /// <summary>
        /// Delete records by their Name
        /// </summary>
        /// <param name="name">The Name to match and delete</param>
        public void DeleteByName(string name)
        {
            var Records = records.Where(record => record.Name == name);
            DeleteRecords(Records);
        }

        /// <summary>
        /// Delete records by their Date
        /// </summary>
        /// <param name="date">The Date to match and delete</param>
        public void DeleteByDate(DateTime date)
        {
            var Records = records.Where(record => record.Date == date);
            DeleteRecords(Records);
        }

        /// <summary>
        /// Find records that fall within a date range
        /// </summary>
        /// <param name="from">The start date of the range</param>
        /// <param name="to">The end date of the range</param>
        /// <returns>Records within the specified date range</returns>
        public IEnumerable<Record> FindByDateBetween(DateTime from, DateTime to)
        {
            return records.Where(record => record.Date >= from).Where(record => record.Date <= to);
        }

        /// <summary>
        /// Order records by their Id
        /// </summary>
        /// <returns>Records ordered by Id</returns>
        public IEnumerable<Record> OrderById()
        {
            return records.OrderBy(record => record.Id);
        }

        /// <summary>
        /// Order records by their Topic
        /// </summary>
        /// <returns>Records ordered by Topic</returns>
        public IEnumerable<Record> OrderByTopic()
        {
            return records.OrderBy(record => record.Topic);
        }

        /// <summary>
        /// Order records by their Body
        /// </summary>
        /// <returns>Records ordered by Body</returns>
        public IEnumerable<Record> OrderByBody()
        {
            return records.OrderBy(record => record.Body);
        }

        /// <summary>
        /// Order records by their Name
        /// </summary>
        /// <returns>Records ordered by Name</returns>
        public IEnumerable<Record> OrderByName()
        {
            return records.OrderBy(record => record.Name);
        }

        /// <summary>
        /// Order records by their Date
        /// </summary>
        /// <returns>Records ordered by Date</returns>
        public IEnumerable<Record> OrderByDate()
        {
            return records.OrderBy(record => record.Date);
        }

        /// <summary>
        /// Override of the ToString method to display records as a concatenated string
        /// </summary>
        /// <returns>A string representing the records</returns>
        public override string ToString()
        {
            return string.Join(",\n", records);
        }
    }
}
